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

        //public static int CambiarDatos(string nombre, string apellido, string apellido2, string email, string contraseña, string telefono, byte admin = 0)
        //{
        //    SqlCommand update = MetodosDatos.CrearComando(CambiarDatos);
        //    update.CommandText = "UPDATE id, nombre, apellido, apellido2, email, contraseña, telefono, admin"
        //    + " FROM USUARIO
        //    + " SET Valor = @NuevoValor
        //    + " WHERE Id = @IdRegistro";
        //
        //    update.Parameters.AddWithValue("@nombre", nombre)
        //    update.Parameters.AddWithValue("@apellido", apellido);
        //    update.Parameters.AddWithValue("@apellido2", apellido2);
        //    update.Parameters.AddWithValue("@email", email);
        //    update.Parameters.AddWithValue("@contraseña", contraseña);
        //    update.Parameters.AddWithValue("@telefono", telefono);
        //    update.Parameters.AddWithValue("@admin", admin);
        //}
    }

}