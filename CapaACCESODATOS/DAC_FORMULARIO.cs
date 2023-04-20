using System.Data.SqlClient;
using System.Data;

namespace CapaACCESODATOS
{
    public class DAC_FORMULARIO
    {
        public static DataTable ObtenerFormulario()
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, apellido, apellido2, email, contra, telefono"
                + " FROM FORMULARIO";
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        //preguntar como hacer esto porque.... madre mia....
    }
}