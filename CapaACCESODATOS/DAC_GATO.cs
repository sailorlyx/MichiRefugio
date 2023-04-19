using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaACCESODATOS
{
    public class DAC_GATO
    {
        public static DataTable ObtenerGatos()
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, edad, genero, descripcion, adoptado, foto, Gusta, Odia "
                + " FROM GATO";
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerGato(int id)
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, edad, genero, descripcion, adoptado, foto, Gusta, Odia"
                + " FROM GATO"
                + " WHERE id = " + id;
            return MetodosDatos.EjecutarComandoSelect(comando);
        }
    }
}
