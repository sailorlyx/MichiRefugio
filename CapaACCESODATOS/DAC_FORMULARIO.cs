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
            comando.CommandText = "SELECT id, nombre, apellido, apellido2, email, telefono, idGato, sobreti"
                + " FROM FORMULARIO";
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        public static int GuardarFormulario(string nombre, string apellido, string apellido2, string email, string telefono, int idGato, string sobreti)
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "INSERT INTO FORMULARIO (nombre, apellido, apellido2, email, telefono, idGato, sobreti)"
            + " VALUES (@nombre, @apellido, @apellido2, @email, @telefono, @idGato, @sobreti)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@apellido2", apellido2);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@idGato", idGato);
            comando.Parameters.AddWithValue("@sobreti", sobreti);
            return MetodosDatos.EjecutarComandoInsert(comando);
        }

        public static int EliminarFormulario(int id)
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "DELETE FROM FORMULARIO WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);

            return MetodosDatos.EjecutarComandoInsert(comando);
        }
    }

}