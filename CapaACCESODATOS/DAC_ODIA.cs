using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaACCESODATOS
{
    public class DAC_ODIA
    {
            public static DataTable ObtenerOdias()
            {
                SqlCommand comando = MetodosDatos.CrearComando();
                comando.CommandText = "SELECT id, descripcion"
                    + " FROM ODIA";
                return MetodosDatos.EjecutarComandoSelect(comando);
            }

            public static DataTable ObtenerOdia(int id)
            {
                SqlCommand comando = MetodosDatos.CrearComando();
                comando.CommandText = "SELECT id, descripcion"
                    + " FROM ODIA"
                    + " WHERE id = " + id;
                return MetodosDatos.EjecutarComandoSelect(comando);
            }
    
    }
}
