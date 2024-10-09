using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Acceso
    {
        SqlConnection conexion = new SqlConnection();
        void Abrir()
        {
            conexion.ConnectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            conexion.Open();
        }
        void Cerrar()
        {
            conexion.Close();
        }
        public DataTable Leer(string st, SqlParameter[] parametros)
        {
            Abrir();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand();
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.CommandText = st;

            if (parametros != null)
            {
                adaptador.SelectCommand.Parameters.AddRange(parametros);
            }
            adaptador.SelectCommand.Connection = conexion;
            adaptador.Fill(tabla);
            Cerrar();
            return tabla;
        }
        public int Escribir(string st, SqlParameter[] parameters)
        {
            int fa = 0;
            Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = st;
            cmd.Connection = conexion;

            cmd.Parameters.AddRange(parameters);

            try
            {
                fa = cmd.ExecuteNonQuery();
            }
            catch
            {
                fa = -1;
            }
            return fa;
        }
    }
}
