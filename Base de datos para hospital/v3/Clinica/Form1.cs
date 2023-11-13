using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form1 : Form
    {
        Conexion conexion;

        public Form1()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los campos de usuario y contraseña
            string username = username_txt.Text;
            string password = password_txt.Text;

            // Crea una consulta SQL para verificar las credenciales
            string query = "SELECT COUNT(*) FROM usuarios WHERE username = @Username AND contraseña = @Password";

            // Abre la conexión a la base de datos
            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                // Agrega parámetros para evitar la inyección de SQL
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                int count = (int)cmd.ExecuteScalar();

                // Verifica si se encontró un usuario con las credenciales proporcionadas
                if (count > 0)
                {
                    // Las credenciales son válidas, así que puedes abrir Form2 o Form3 según el usuario
                    if (username == "Director Medico")
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else if (username == "Oficial Personal")
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                    }
                    else if (username == "Enfermera")
                    {
                        Form4 form4 = new Form4();
                        form4.Show();
                    }

                    this.Hide();
                }
                else
                {
                    // Las credenciales no son válidas, muestra un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }

            // Cierra la conexión a la base de datos
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: Director Medico\nContraseña: director2023\n\nUsuario: Oficial Personal\nContraseña: oficial2023\n\nUsuario: Enfermera\nContraseña: enfermera2023");
        }
    }
}
