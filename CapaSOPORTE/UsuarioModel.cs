using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        //[Required(ErrorMessage = "Email no válido")]
        public string email { get; set; }

        //[Required(ErrorMessage = "Contraseña no válida")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "Contraseña no válida")]
        public string contraseña { get; set; }
        public string telefono { get; set; }
        public bool admin { get; set; }

        public UsuarioModel()
        { }

        public UsuarioModel(DataRow row)
        {
            id = row.Field<int>("id");
            nombre = row.Field<string>("nombre");
            apellido = row.Field<string>("apellido");
            apellido2 = row.Field<string>("apellido2");
            email = row.Field<string>("email");
            contraseña = row.Field<string>("contraseña");
            telefono = row.Field<string>("telefono");
            admin = Utilidades.TinyintABool( row.Field<byte>("admin"));
        }
    }
}
