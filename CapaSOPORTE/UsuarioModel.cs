using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSOPORTE
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string apellido2 { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
        public int telefono { get; set; }
        public bool admin { get; set; }

        public UsuarioModel(DataRow row)
        {
            id = row.Field<int>("id");
            nombre = row.Field<string>("nombre");
            apellido = row.Field<string>("apellido");
            apellido2 = row.Field<string>("apellido2");
            email = row.Field<string>("email");
            contraseña = row.Field<string>("contraseña");
            telefono = row.Field<int>("telefono");
            admin = row.Field<bool>("admin");
        }
    }
}
