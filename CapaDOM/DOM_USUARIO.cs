using CapaACCESODATOS;
using CapaSOPORTE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDOM
{
    public class DOM_USUARIO
    {
        public static List<UsuarioModel> ConseguirUsuarioPorEmail(string email)
        {
            DataTable dt = DAC_USUARIO.ConseguirUsuarioPorEmail(email);

            List<UsuarioModel> lista = new List<UsuarioModel>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new UsuarioModel(row));
            }

            return lista;
        }
        public static void RegistrarUsuario(string nombre, string apellido, string apellido2, string email, string contraseña, string telefono)
        {
            contraseña = Utilidades.EncriptarContra(contraseña);

            DAC_USUARIO.RegistrarUsuario(nombre, apellido, apellido2, email, contraseña,telefono);
        }
        public static List<UsuarioModel> ObtenerUsuarios()
        {
            DataTable dt = DAC_USUARIO.ObtenerUsuarios();

            List<UsuarioModel> lista = new List<UsuarioModel>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new UsuarioModel(row));
            }

            return lista;
        }

        public static List<UsuarioModel> ObtenerUsuario(int id)
        {
            DataTable dt = DAC_USUARIO.ObtenerUsuario(id);

            List<UsuarioModel> lista = new List<UsuarioModel>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new UsuarioModel(row));
            }

            return lista;
        }
    }
}
