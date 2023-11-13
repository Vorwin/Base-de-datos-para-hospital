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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clinica
{
    public partial class Form2 : Form
    {

        Conexion conexion = new Conexion();

        public Form2()
        {
            InitializeComponent();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void MostrarPersonal(object sender, EventArgs e)
        {
            string query = "SELECT * FROM personal"; // Consulta SQL para obtener todos los datos de la tabla personal

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgPersonal.DataSource = dt;
            }

            conexion.Close();
        }

        private void MostarPacientes(object sender, EventArgs e)
        {
            string query = "SELECT * FROM pacientes"; // Consulta SQL para obtener todos los datos de la tabla pacientes

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgPacientes.DataSource = dt; // Asigna el DataTable al DataGridView
            }

            conexion.Close();
        }

        private void MostrarProveedores(object sender, EventArgs e)
        {
            //Mostar Proveedores
            string query = "SELECT * FROM proveedor"; //Obetener datos de proveedores

            conexion.Open();
            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgProveedores.DataSource = dt; // Asigna el DataTable al DataGridView
            }

            conexion.Close();
        }

        private void MostarSalas(object sender, EventArgs e)
        {
            string query = "SELECT s.no_sala, s.Nombre_sala, u.ubicaciones " +
                           "FROM salas s " +
                           "INNER JOIN ubicaciones u ON s.id_ubicaciones = u.id_ubicaciones";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgSalas.DataSource = dt; // Asigna el DataTable al DataGridView para mostrar salas, clínicas y ubicaciones
            }

            conexion.Close();
        }

        private void MostrarCama(object sender, EventArgs e)
        {
            string query = "SELECT no_sala, no_cama FROM salas";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgCamas.DataSource = dt;
            }

            conexion.Close();
        }

        private void MostrarMedicina(object sender, EventArgs e)
        {
            string query = "SELECT m.no_medicamento, m.nombre, d.descripcion " +
                           "FROM medicamentos m " +
                           "INNER JOIN descripcion d ON m.codigo_descripcion = d.codigo_descripcion";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgMedicina.DataSource = dt; // Asigna el DataTable al DataGridView para mostrar medicamentos y descripciones
            }

            conexion.Close();
        }

        private void mostrar_clinicas(object sender, EventArgs e)
        {
            string query = "Select * from clinicas";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgClinicas.DataSource = dt; // Asigna el DataTable al DataGridView para mostrar clinicas
            }

            conexion.Close();
        }

        private void agregar_proveedor(object sender, EventArgs e)
        {

            // Obtener los valores de los TextBox
            string no_prov = txt_no_p.Text;
            string nombre = txt_nombreP.Text;
            string direccion = txt_direP.Text;
            string telefono = txt_telP.Text;
            string fax = txt_fax.Text;

            // Validar que los campos no estén vacíos
            if (!string.IsNullOrWhiteSpace(nombre) &&
                !string.IsNullOrWhiteSpace(direccion) &&
                !string.IsNullOrWhiteSpace(telefono) &&
                !string.IsNullOrWhiteSpace(fax) &&
                !string.IsNullOrWhiteSpace(no_prov))
            {
                // Insertar los datos en la base de datos
                if (insertarproveedor(no_prov, nombre, direccion, telefono, fax))
                {
                    MessageBox.Show("Proveedor ingresado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al ingresar proveedor.");
                }
            }
            else
            {
                MessageBox.Show("Asegúrate de completar todos los campos.");
            }
        }

        private bool insertarproveedor(string no_p, string nombre, string direccion, string tele, string fax)
        {
            string query = "insert into proveedor (no_proveedor, nombre, direccion, telefono, numero_fax) " +
                           "VALUES (@no_p, @nombre, @direccion, @tele, @fax)";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@no_p", no_p);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@tele", tele);
                cmd.Parameters.AddWithValue("@fax", fax);

                int rowsAffected = cmd.ExecuteNonQuery();

                conexion.Close();

                return rowsAffected > 0;
            }
        }

        private void btnIngresarPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                string personal = no_personal.Text;
                string nombre = nombre_personal.Text;
                string apellido = apellido_personal.Text;
                string direccion = direccion_personal.Text;
                string sexo = sexo_personal.SelectedIndex.ToString();
                string fechaNacimiento = fecha_personal.Text;
                string telefono = telefono_personal.Text;
                string idPuesto = id_puesto.Text;
                string Nss = nss.Text;
                string horasXsemana = horasxsemana.Text;
                int salarioActual = Convert.ToInt32(salario_personal.Text);
                int pagoSemanalMensual = Convert.ToInt32(pago_semanal.Text);
                string idEscalaSalarial = id_escala.Text;
                string permanenteTemporal = tt_contrato.SelectedIndex.ToString();
                string idTurnos = id_turnos.Text;

                if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido) &&
                    !string.IsNullOrWhiteSpace(direccion) && !string.IsNullOrWhiteSpace(sexo) &&
                    !string.IsNullOrWhiteSpace(fechaNacimiento) && !string.IsNullOrWhiteSpace(telefono) &&
                    !string.IsNullOrWhiteSpace(idPuesto) && !string.IsNullOrWhiteSpace(Nss) &&
                    !string.IsNullOrWhiteSpace(horasXsemana) && salarioActual >= 0 &&
                    pagoSemanalMensual >= 0 && !string.IsNullOrWhiteSpace(idEscalaSalarial) &&
                    !string.IsNullOrWhiteSpace(permanenteTemporal) && !string.IsNullOrWhiteSpace(idTurnos))
                {
                    if (InsertarNuevoPersonal(personal, nombre, apellido, direccion, sexo, fechaNacimiento,
                                              telefono, idPuesto, Nss, horasXsemana, salarioActual,
                                              pagoSemanalMensual, idEscalaSalarial, permanenteTemporal, idTurnos))
                    {
                        MessageBox.Show("Nuevo personal ingresado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar nuevo personal.");
                    }
                }
                else
                {
                    MessageBox.Show("Asegúrate de completar todos los campos correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool InsertarNuevoPersonal(string personal, string nombre, string apellido, string direccion, string sexo, string fechaNacimiento,
    string telefono, string idPuesto, string nss, string horasXsemana, decimal salarioActual,
    decimal pagoSemanalMensual, string idEscalaSalarial, string permanenteTemporal, string idTurnos)
        {
            // Primero, verifica si los ID de escala salarial, turno y puesto existen. Si no existen, créalos.
            if (!VerificarYCrearRegistro("Escala_Salariales", "id_escala_salarial", idEscalaSalarial) ||
                !VerificarYCrearRegistro("Turnos", "id_turnos", idTurnos) ||
                !VerificarYCrearRegistro("puestos", "id_puesto", idPuesto))
            {
                MessageBox.Show("Error al verificar o crear registros en las tablas relacionadas.");
                return false;
            }

            string query = "INSERT INTO personal (no_personal,nombre, apellido, Direccion, Sexo, fecha_nacimiento, telefono, id_puesto, NSS, horasXsemana, salario_actual, pago_semanal_mensual, id_escala_salarial, permanente_temporal, id_turnos) " +
                           "VALUES (@personal,@nombre, @apellido, @direccion, @sexo, @fechaNacimiento, @telefono, @idPuesto, @nss, @horasXsemana, @salarioActual, @pagoSemanalMensual, @idEscalaSalarial, @permanenteTemporal, @idTurnos)";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@personal", personal);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@fechaNacimiento", Convert.ToDateTime(fechaNacimiento));
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                cmd.Parameters.AddWithValue("@nss", nss);
                cmd.Parameters.AddWithValue("@horasXsemana", horasXsemana);
                cmd.Parameters.AddWithValue("@salarioActual", salarioActual);
                cmd.Parameters.AddWithValue("@pagoSemanalMensual", pagoSemanalMensual);
                cmd.Parameters.AddWithValue("@idEscalaSalarial", idEscalaSalarial);
                cmd.Parameters.AddWithValue("@permanenteTemporal", permanenteTemporal);
                cmd.Parameters.AddWithValue("@idTurnos", idTurnos);

                int rowsAffected = cmd.ExecuteNonQuery();

                conexion.Close();

                return rowsAffected > 0;
            }
        }

        private bool VerificarYCrearRegistro(string tabla, string campoID, string valorID)
        {
            // Verifica si el registro con el valor de campoID ya existe en la tabla.
            string query = $"SELECT COUNT(*) FROM {tabla} WHERE {campoID} = @valorID";

            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                cmd.Parameters.AddWithValue("@valorID", valorID);

                int count = (int)cmd.ExecuteScalar();

                if (count == 0)
                {
                    // Si no existe, crea el registro con el valor de campoID.
                    query = $"INSERT INTO {tabla} ({campoID}) VALUES (@valorID)";
                    cmd.CommandText = query;
                    int rowsAffected = cmd.ExecuteNonQuery();

                    conexion.Close();

                    return rowsAffected > 0;
                }

                conexion.Close();

                return true;
            }
        }

        private void btn_agregarCama_Click(object sender, EventArgs e)
        {
            try
            {
                string no_sala = noSala.Text;

                // 1. Obtén el número de cama actual de la sala especificada
                string query = "SELECT no_cama FROM salas WHERE no_sala = @no_sala";

                conexion.Open();

                using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
                {
                    cmd.Parameters.AddWithValue("@no_sala", no_sala);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int numeroCamaActual = Convert.ToInt32(result);
                        int nuevoNumeroCama = numeroCamaActual + 1;

                        query = "UPDATE salas SET no_cama = @nuevoNumeroCama WHERE no_sala = @no_sala";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@nuevoNumeroCama", nuevoNumeroCama);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Número de cama actualizado correctamente.");
                            MostrarSalasConCamas(sender, e); // Actualizar el DataGridView después de la operación
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el número de cama.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la sala especificada.");
                    }
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Función para mostrar las salas junto con el número de camas
        private void MostrarSalasConCamas(object sender, EventArgs e)
        {
            string query = "SELECT no_sala, no_cama FROM salas";

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

        private void Form2_Load(object sender, EventArgs e)
        {
            MostrarSalasConCamas(sender, e);
        }

        private void btnAgregarMedicina_Click(object sender, EventArgs e)
        {
            string no_medicamento = no_medicina.Text;
            string nombre = nombre_medicina.Text;
            string codigo_desc = codigo_descripcion.Text;
            string descripcion = descripcion_medicina.Text;

            try
            {
                // 1. Verificar si el código de descripción ya existe en la tabla 'descripcion'
                string query = "SELECT COUNT(*) FROM descripcion WHERE codigo_descripcion = @codigo_desc";

                conexion.Open();

                using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
                {
                    cmd.Parameters.AddWithValue("@codigo_desc", codigo_desc);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        // 2. Si el código de descripción no existe, insertarlo en la tabla 'descripcion'
                        query = "INSERT INTO descripcion (codigo_descripcion, descripcion) VALUES (@codigo_desc, @descripcion)";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // 3. Después de insertar el código de descripción, ahora puedes insertar la medicina en la tabla 'medicamentos'
                            query = "INSERT INTO medicamentos (no_medicamento, nombre, codigo_descripcion) VALUES (@no_medicamento, @nombre, @codigo_desc)";

                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@no_medicamento", no_medicamento);
                            cmd.Parameters.AddWithValue("@nombre", nombre);

                            rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Medicamento ingresado correctamente.");
                            }
                            else
                            {
                                MessageBox.Show("Error al ingresar el medicamento.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al ingresar el código de descripción.");
                        }
                    }
                    else
                    {
                        // 4. Si el código de descripción ya existe, solo inserta la medicina en la tabla 'medicamentos'
                        query = "INSERT INTO medicamentos (no_medicamento, nombre, codigo_descripcion) VALUES (@no_medicamento, @nombre, @codigo_desc)";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@no_medicamento", no_medicamento);
                        cmd.Parameters.AddWithValue("@nombre", nombre);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medicamento ingresado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al ingresar el medicamento.");
                        }
                    }
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
