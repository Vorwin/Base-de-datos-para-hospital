using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form4 : Form
    {

        Conexion conexion = new Conexion();

        public Form4()
        {
            InitializeComponent();
            ObtenerNumeroPacienteAnterior();
        }

        static string nombre;
        static string apellido;
        static string telefono;
        static string direccion;
        static string fecha_nacimiento;
        static string estado_civil;
        static string fecha_registro;
        static string sexo;
        static string no_paciente;

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            nombre = nombre_paciente.Text;
            apellido = apellido_paciente.Text;
            telefono = telefono_paciente.Text;
            direccion = direccion_paciente.Text;
            fecha_nacimiento = fecha1.Text;
            estado_civil = estado_civil_paciente.Text;
            fecha_registro = fecha2.Text;
            sexo = sexo_paciente.Text;

            // Obtener el número de paciente anterior o el último
            int numeroPacienteAnterior = ObtenerNumeroPacienteAnterior();

            // Incrementar el número de paciente para el nuevo paciente
            int nuevoNumeroPaciente = numeroPacienteAnterior + 1;
            no_paciente = nuevoNumeroPaciente.ToString();

            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido) &&
                !string.IsNullOrWhiteSpace(telefono) && !string.IsNullOrWhiteSpace(direccion) &&
                !string.IsNullOrWhiteSpace(fecha_nacimiento) && !string.IsNullOrWhiteSpace(estado_civil) &&
                !string.IsNullOrWhiteSpace(fecha_registro) && !string.IsNullOrWhiteSpace(sexo) && !string.IsNullOrWhiteSpace(no_paciente))
            {
                // Guardar el nuevo paciente en la base de datos
                GuardarNuevoPaciente();
                MessageBox.Show("Paciente ingresado correctamente");
            }
            else
            {
                MessageBox.Show("Asegúrese de completar todos los campos, incluyendo el número de paciente.");
            }

            //Formatear todos los campos, y darle + 1 al número de paciente
            nombre_paciente.Text = "";
            apellido_paciente.Text = "";
            telefono_paciente.Text = "";
            direccion_paciente.Text = "";
            fecha1.Text = "";
            estado_civil_paciente.Text = "";
            fecha2.Text = "";
            sexo_paciente.Text = "";
            id_paciente.Value = nuevoNumeroPaciente + 1;
        }

        private int ObtenerNumeroPacienteAnterior()
        {
            int numeroPacienteAnterior = 0;

            // Consulta SQL para obtener el último ID de pacientes
            string query = "SELECT MAX(no_paciente) FROM pacientes";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                // Ejecuta la consulta y obtén el resultado
                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    numeroPacienteAnterior = Convert.ToInt32(result);
                }
            }

            conexion.Close();

            // Asigna el valor al control NumericUpDown id_paciente
            id_paciente.Value = numeroPacienteAnterior + 1;

            return numeroPacienteAnterior;
        }


        private void GuardarNuevoPaciente()
        {
            // Consulta SQL para insertar un nuevo paciente en la base de datos
            string query = "INSERT INTO pacientes (no_paciente, nombre, apellido, direccion, fecha_nacimiento, fecha_registro, sexo, telefono, estado_civil) " +
                           "VALUES (@NoPaciente, @Nombre, @Apellido, @Direccion, @FechaNacimiento, @FechaRegistro, @Sexo, @Telefono, @EstadoCivil)";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fecha_nacimiento); // Usar el valor de fecha_nacimiento
                cmd.Parameters.AddWithValue("@EstadoCivil", estado_civil);
                cmd.Parameters.AddWithValue("@FechaRegistro", fecha_registro); // Usar el valor de fecha_registro
                cmd.Parameters.AddWithValue("@Sexo", sexo);
                cmd.Parameters.AddWithValue("@NoPaciente", no_paciente);

                cmd.ExecuteNonQuery();
            }

            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Mostrar personal
        private void mostarPersonal(object sender, EventArgs e)
        {
            string query = "SELECT personal.No_personal as Codigo, personal.nombre, personal.apellido, puestos.puesto, salas.no_sala as CodigoSala, salas.Nombre_sala as Sala " +
                           "FROM personal " +
                           "INNER JOIN puestos ON puestos.id_puesto = personal.id_puesto " +
                           "LEFT JOIN detalle_personal_sala ON personal.No_personal = detalle_personal_sala.No_personal " +
                           "LEFT JOIN salas ON detalle_personal_sala.no_sala = salas.no_sala";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dg1.DataSource = dt;
            }

            conexion.Close();

        }

        //Rotar Personal
        private void btn_rotar_Click(object sender, EventArgs e)
        {
            string codigoPersonal = personal_txt.Text;
            string codigoSala = sala_txt.Text;

            bool existePersonal = ExisteCodigoEnBaseDeDatos("personal", "No_personal", codigoPersonal);

            bool existeSala = ExisteCodigoEnBaseDeDatos("salas", "no_sala", codigoSala);

            if (!existePersonal)
            {
                MessageBox.Show("El código de personal ingresado no existe.");
                return;
            }

            if (!existeSala)
            {
                MessageBox.Show("El código de sala ingresado no existe.");
                return;
            }

            // Realiza la rotación de personal en la base de datos
            if (RealizarRotacionEnBaseDeDatos(codigoPersonal, codigoSala))
            {
                MessageBox.Show("Rotación de personal exitosa.");
            }
            else
            {
                MessageBox.Show("No se pudo realizar la rotación de personal.");
            }

            // Actualiza el DataGridView
            mostarPersonal(sender, e);
        }

        private bool ExisteCodigoEnBaseDeDatos(string tabla, string columna, string codigo)
        {

            Conexion conexion = new Conexion();
            conexion.Open();
            string query = $"SELECT COUNT(*) FROM {tabla} WHERE {columna} = @Codigo";


            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                int count = (int)cmd.ExecuteScalar();
                conexion.Close();
                return count > 0;
            }
        }

        private bool RealizarRotacionEnBaseDeDatos(string codigoPersonal, string codigoSala)
        {

            Conexion conexion = new Conexion();
            conexion.Open();
            string query = "UPDATE detalle_personal_sala SET no_sala = @CodigoSala WHERE No_personal = @CodigoPersonal";

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@CodigoSala", codigoSala);
                cmd.Parameters.AddWithValue("@CodigoPersonal", codigoPersonal);
                int rowsAffected = cmd.ExecuteNonQuery();
                conexion.Close();
                return rowsAffected > 0;
            }
        }

        private void AgregarPariente(object sender, EventArgs e)
        {
            // Obtener los datos desde los TextBox
            string nombrePariente = nombre_pariente.Text;
            string apellidoPariente = apellido_pariente.Text;
            string relacioon = relacion.Text;
            string direccionPariente = direccion_pariente.Text;
            string telefonoPariente = telefono_pariente.Text;

            // Obtener el ID del paciente desde el NumericUpDown
            int idPacienteP = Convert.ToInt32(no_pacientep.Text);

            // Verificar si el ID del paciente existe en la base de datos
            if (ExistePacienteEnBaseDeDatos(idPacienteP))
            {
                // Obtener el próximo ID de parentesco
                int nuevoIdParentesco = ObtenerProximoIdParentesco();

                // Insertar el nuevo pariente en la base de datos
                if (InsertarNuevoPariente(nuevoIdParentesco, nombrePariente, apellidoPariente, relacioon, direccionPariente, telefonoPariente, idPacienteP))
                {
                    MessageBox.Show("Pariente agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al agregar el pariente.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de paciente válido.");
            }
        }

        private bool ExistePacienteEnBaseDeDatos(int idPacienteP)
        {
            // Consulta SQL para verificar si el ID del paciente existe en la base de datos
            string query = "SELECT COUNT(*) FROM pacientes WHERE no_paciente = @IdPacienteP";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@IdPacienteP", idPacienteP);

                int count = (int)cmd.ExecuteScalar();

                conexion.Close();

                return count > 0;
            }
        }

        private int ObtenerProximoIdParentesco()
        {
            int proximoIdParentesco = 1; // El primer ID de parentesco

            // Consulta SQL para obtener el próximo ID de parentesco
            string query = "SELECT MAX(id_parentesco) FROM parentesco";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    proximoIdParentesco = Convert.ToInt32(result) + 1;
                }
            }

            conexion.Close();

            return proximoIdParentesco;
        }

        private bool InsertarNuevoPariente(int nuevoIdParentesco, string nombrePariente, string apellidoPariente, string relacion, string direccionPariente, string telefonoPariente, int idPacienteP)
        {
            // Consulta SQL para insertar el nuevo pariente en la base de datos
            string query = "INSERT INTO parentesco (id_parentesco, nombre, apellido, relacion, direccion, telefono, id_paciente) " +
                           "VALUES (@IdParentesco, @NombrePariente, @ApellidoPariente, @Relacion, @DireccionPariente, @TelefonoPariente, @IdPacienteP)";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@IdParentesco", nuevoIdParentesco);
                cmd.Parameters.AddWithValue("@NombrePariente", nombrePariente);
                cmd.Parameters.AddWithValue("@ApellidoPariente", apellidoPariente);
                cmd.Parameters.AddWithValue("@Relacion", relacion);
                cmd.Parameters.AddWithValue("@DireccionPariente", direccionPariente);
                cmd.Parameters.AddWithValue("@TelefonoPariente", telefonoPariente);
                cmd.Parameters.AddWithValue("@IdPacienteP", idPacienteP);

                int rowsAffected = cmd.ExecuteNonQuery();

                conexion.Close();

                return rowsAffected > 0;
            }
        }

        private void IngresarAmbulatorio(object sender, EventArgs e)
        {
            string nombreSala = clinicaA.SelectedItem.ToString(); // Obtener el nombre seleccionado en el ComboBox

            if (nombreSala == "Sala de Emergencias" || nombreSala == "Sala de Cirugía")
            {
                int idPaciente = (int)id_pacienteA.Value;

                if (ExistePacienteEnBaseDeDatos(idPaciente))
                {
                    int idSala = ObtenerIdSalaPorNombre(nombreSala);

                    if (idSala > 0)
                    {
                        if (AsignarPacienteASalaEnBaseDeDatos(idPaciente, idSala))
                        {
                            MessageBox.Show("Paciente asignado a la sala correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al asignar al paciente a la sala.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre de sala no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID del paciente no existe en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una sala válida.");
            }
        }

        private int ObtenerIdSalaPorNombre(string nombreSala)
        {
            string query = "SELECT no_sala FROM salas WHERE Nombre_sala = @NombreSala";
            Conexion conexion = new Conexion();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@NombreSala", nombreSala);
                conexion.Open();
                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                conexion.Close();
            }

            return -1; // Retorna -1 si no se encontró el nombre de la sala
        }

        private bool AsignarPacienteASalaEnBaseDeDatos(int idPaciente, int idSala)
        {
            string query = "INSERT INTO detalle_paciente_sala (no_paciente, no_sala) VALUES (@IdPaciente, @IdSala)";
            Conexion conexion = new Conexion();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                cmd.Parameters.AddWithValue("@IdSala", idSala);
                conexion.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conexion.Close();
                return rowsAffected > 0;
            }
        }
    }
}
