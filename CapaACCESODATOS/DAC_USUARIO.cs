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
        public static DataTable ObtenerUsuarios()
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, apellido, apellido2, email, telefono, contraseña, admin"
                + " FROM USUARIO";
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerUsuario(int id)
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, apellido, apellido2, email, telefono, contraseña, admin"
                + " FROM USUARIO"
                + " WHERE id = " + id;
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        //public static int ModificarUsuario(string nombre, string apellido, string apellido2, string email, string telefono)
        //{
        //    SqlCommand comando = MetodosDatos.CrearComando();
        //    comando.CommandText = "UPDATE USUARIO SET nombre = @nombre, apellido = @apellido, apellido2 = @apellido2, email = @email, telefono = @telefono"
        //       + " WHERE id = @id";
        //    comando.Parameters.AddWithValue("@nombre", nombre);
        //    comando.Parameters.AddWithValue("@apellido", apellido);
        //    comando.Parameters.AddWithValue("@apellido2", apellido2);
        //    comando.Parameters.AddWithValue("@email", email);   
        //    comando.Parameters.AddWithValue("@telefono", telefono);

        //    return MetodosDatos.EjecutarComandoInsert(comando);
            
        //}

        //public static int EliminarUsuario(int id)
        //{
        //    SqlCommand comando = MetodosDatos.CrearComando();
        //    comando.CommandText = "DELETE FROM USUARIO WHERE id = @id";
        //    comando.Parameters.AddWithValue("@id", id);

        //    return MetodosDatos.EjecutarComandoInsert(comando);
        //}

    }

}