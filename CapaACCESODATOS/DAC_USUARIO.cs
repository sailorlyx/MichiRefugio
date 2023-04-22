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
        public static DataTable ConseguirUsuarioPorEmail(string email)
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, apellido, apellido2, email, contraseña, telefono, admin"
                + " FROM USUARIO"
                + " WHERE email = '" + email + "'";
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        public static int RegistrarUsuario(string nombre, string apellido, string apellido2, string email, string contraseña, string telefono, byte admin = 0)
        {
            SqlCommand procedureowo = MetodosDatos.CrearComandoProc("RegistrarUsuario");
            procedureowo.Parameters.AddWithValue("@nombre", nombre);
            procedureowo.Parameters.AddWithValue("@apellido", apellido);
            procedureowo.Parameters.AddWithValue("@apellido2", apellido2);
            procedureowo.Parameters.AddWithValue("@email", email);
            procedureowo.Parameters.AddWithValue("@contraseña", contraseña);
            procedureowo.Parameters.AddWithValue("@telefono", telefono);
            procedureowo.Parameters.AddWithValue("@admin", admin);
            return MetodosDatos.EjecutarComandoInsert(procedureowo);

        }
    }

}