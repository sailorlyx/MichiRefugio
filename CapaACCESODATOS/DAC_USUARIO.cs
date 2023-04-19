using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaACCESODATOS
{
    public class DAC_USUARIO
    {
        public static DataTable ObtenerUsuarios()
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, apellido, apellido2, email, contraseña, telefono, admin"
                + " FROM USUARIO";
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerUsuario(int id)
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, apellido, apellido2, email, contraseña, telefono, admin"
                + " FROM USUARIO"
                + " WHERE id = " + id;
            return MetodosDatos.EjecutarComandoSelect(comando);
        }
    }
}
