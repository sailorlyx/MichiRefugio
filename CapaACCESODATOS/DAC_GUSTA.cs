using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaACCESODATOS
{
    public class DAC_GUSTA
    {
        public static DataTable ObtenerGustas()
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, descripcion"
                + " FROM GUSTA";
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerGusta(int id)
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, descripcion"
                + " FROM GUSTA"
                + " WHERE id = " + id;
            return MetodosDatos.EjecutarComandoSelect(comando);
        }
    }
}
