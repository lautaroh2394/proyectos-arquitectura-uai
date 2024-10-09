using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_conexion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("start");
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            cn.Open();
            cn.Close();
            Console.WriteLine("exito");
        }
    }
}
