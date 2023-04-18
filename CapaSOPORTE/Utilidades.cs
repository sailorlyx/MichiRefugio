using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSOPORTE
{
    public class Utilidades
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
    }
}
