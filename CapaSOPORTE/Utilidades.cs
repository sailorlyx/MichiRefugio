using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSOPORTE
{
    public static class Utilidades
    {
        public static bool TinyintABool(byte numero)
        {
            if (numero == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Genero(string genero)
        {
            if (genero == "M")
            {
                return "macho";
            }
            else
            {
                return "hembra";
            }
        }

        public static string Generoformulario(string genero)
        {
            if (genero == "M")
            {
                return "¿Quieres adoptarlo?";
            }
            else
            {
                return "¿Quieres adoptarla?";
            }
        }
        //añadirrrrrrrrrrrrr

        public static string EncriptarContra(this string contra)
        {
            return BCrypt.Net.BCrypt.HashPassword(contra);
        }

        public static bool ComprobarContra(string contraFormulario, string contraBBDD)
        {
            return BCrypt.Net.BCrypt.Verify(contraFormulario, contraBBDD);
        }
    }
}
