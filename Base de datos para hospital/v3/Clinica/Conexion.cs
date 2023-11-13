using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;

namespace Clinica
{
    internal class Conexion
    {
        public SqlConnection SqlCon;
        public void Open()
        {
            string nombre_servidor = Dns.GetHostName();

            SqlCon = new SqlConnection("Data Source="+nombre_servidor+"\\SQLEXPRESS;Initial Catalog=PROYECTO;Integrated Security=True");

            SqlCon.Open();
        }

        public void Close()
        {
            SqlCon.Close();
        }

        public string Cadena() 
        { 
            return SqlCon.ConnectionString;
        }
    }
}
