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
    public partial class Form3 : Form
    {
        Conexion conexion;

        public Form3()
        {
            InitializeComponent();
            conexion = new Conexion();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }


        //Mostrar personal
        private void button2_Click(object sender, EventArgs e)
        {
            //Query para mostrar el personal
            string query = "Select personal.No_personal as Codigo, personal.nombre, personal.apellido, puestos.puesto from personal inner join puestos on puestos.id_puesto = personal.id_puesto";
            conexion.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.SqlCon);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Query para mostrar el detalle personal sala
            string query = "Select personal.No_personal as Codigo, personal.nombre, personal.apellido, salas.Nombre_sala  as Sala from personal, salas, detalle_personal_sala where personal.No_personal = detalle_personal_sala.No_personal and detalle_personal_sala.no_sala = salas.no_sala";
            conexion.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.SqlCon);
            DataTable dt2 = new DataTable();
            adaptador.Fill(dt2);
            dataGridView1.DataSource = dt2;
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Query para mostrar las sala
            string query = "Select salas.no_sala as Codigo, salas.Nombre_sala from salas";
            conexion.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.SqlCon);
            DataTable dt3 = new DataTable();
            adaptador.Fill(dt3);
            dataGridView1.DataSource = dt3;
            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //Query para asiganar personal con sala
            string query = "insert into detalle_personal_sala values(" + personal_txt.Text + "," + sala_txt.Text + ")";
            conexion.Open();

            SqlCommand comando = new SqlCommand(query, conexion.SqlCon);
            comando.ExecuteNonQuery();
            personal_txt.Text = "";
            sala_txt.Text = "";
            MessageBox.Show("Se asigo el codigo personal: " + personal_txt.Text + " a la sala" + sala_txt.Text);
            conexion.Close();
        }
    }
}
