using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSOPORTE
{
    public class InicioSesionModel
    {
        [Required(ErrorMessage = "Email no válido")]
        //[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Correo electrónico incorrecto")]
        public string email { get; set; }

        [Required(ErrorMessage = "Contraseña no válida")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "Contraseña no válida")]
        public string contraseña { get; set; }

        public InicioSesionModel()
        { }

        public InicioSesionModel(DataRow row)
        {
            email = row.Field<string>("email");
            contraseña = row.Field<string>("contraseña");
        }

    }
}
