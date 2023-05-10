using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CapaACCESODATOS
{
    public class MetodosDatos
    {
        public static SqlCommand CrearComando()
        {
            string cadenaConexion = CreateConnection();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand();
            comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            return comando;
        }

        public static SqlCommand CrearComandoProc(string nombreProcedimiento)
        {
            string cadenaConexion = CreateConnection();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            return comando;
        }

        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
            }
            finally
            { comando.Connection.Close(); }
            return tabla;
        }

        public static int EjecutarComandoInsert(SqlCommand procedureowo)
        {
            try
            {
                procedureowo.Connection.Open();
                return procedureowo.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
            }
            finally
            {
                procedureowo.Connection.Dispose();
                procedureowo.Connection.Close();
            }
            return -1;
        }

        public static string CreateConnection()
        {
            var constructor = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var bbdd = constructor.Build().GetSection("ConnectionStrings").GetSection("DemoDBConnectionString").Value;

            return bbdd;
        }
    }

}
