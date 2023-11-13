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
            // Obt�n los valores de los campos de usuario y contrase�a
            string username = username_txt.Text;
            string password = password_txt.Text;

            // Crea una consulta SQL para verificar las credenciales
            string query = "SELECT COUNT(*) FROM usuarios WHERE username = @Username AND contrase�a = @Password";

            // Abre la conexi�n a la base de datos
            conexion.Open();

            using (SqlCommand cmd = new SqlCommand(query, conexion.SqlCon))
            {
                // Agrega par�metros para evitar la inyecci�n de SQL
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                int count = (int)cmd.ExecuteScalar();

                // Verifica si se encontr� un usuario con las credenciales proporcionadas
                if (count > 0)
                {
                    // Las credenciales son v�lidas, as� que puedes abrir Form2 o Form3 seg�n el usuario
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
                    // Las credenciales no son v�lidas, muestra un mensaje de error
                    MessageBox.Show("Usuario o contrase�a incorrectos");
                }
            }

            // Cierra la conexi�n a la base de datos
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: Director Medico\nContrase�a: director2023\n\nUsuario: Oficial Personal\nContrase�a: oficial2023\n\nUsuario: Enfermera\nContrase�a: enfermera2023");
        }
    }
}
