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

        //PREGUNTAR A ANGEL/CRIS/alguien pofavo

        //public bool ValidarUsuario(string email, string contraseña)
        //{
        //    bool usuarioValido = false;

        //    try
        //    {
        //        conexion.Open();
        //        SqlCommand comando = MetodosDatos.CrearComando();
        //        comando.CommandText = "SELECT * FROM USUARIO "
        //            + " WHERE email=@email" 
        //            + " AND contraseña=@contraseña" + conexion;
        //        return MetodosDatos.EjecutarComandoSelect(comando);

        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine("Email y/o contraseña incorrectos " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (conexion.State == ConnectionState.Open)
        //        {
        //            conexion.Close();
        //        }
        //    }

        //    return usuarioValido;

        //}
    }

}