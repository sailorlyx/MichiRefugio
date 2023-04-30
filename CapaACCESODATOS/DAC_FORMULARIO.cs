using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Xml.Schema;

namespace CapaACCESODATOS
{
    public class DAC_FORMULARIO
    {
        public static DataTable ObtenerFormularios()
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, apellido, apellido2, email, contra, telefono"
                + " FROM FORMULARIO";
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        
       
        //public static DataTable InsertarDatos()
        //{
        //    SqlCommand comando = MetodosDatos.CrearComando();
        //    comando.CommandText = "INSERT INTO FORMULARIO (nombre, apellido, apellido2, email, contra, telefono)"
        //    + " VALUES (@nombre, @apellido, @apellido2, @email, @contra, @telefono)";
        //    //comando.Parameters.AddWithValue("@nombre", comando.nombre);
        //    //comando.Parameters.AddWithValue("@apellido", comando.apellido);
        //    //comando.Parameters.AddWithValue("@apellido2", comando.apellido2);
        //    //comando.Parameters.AddWithValue("@email", comando.email);
        //    //comando.Parameters.AddWithValue("@telefono", comando.telefono);
        //    //comando.Parameters.AddWithValue("@contra", comando.contra);
        //    //comando.ExecuteNonQuery();
        //    //sospecho que esto no va aquí

        //}
    }
}