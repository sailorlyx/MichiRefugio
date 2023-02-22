using System.ComponentModel.DataAnnotations;

namespace MichiRefugio.Models
{
    public class RegistroModel
    {
        [Required(ErrorMessage = "Rellena este campo correctamente")]
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Nombre no válido")]

        public string nombre { get; set; }

        [Required(ErrorMessage = "Rellena este campo correctamente")]
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Apellido/s no válido/s")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "Rellena este campo correctamente")]
        [RegularExpression(@"\w+(\s\w+){2,}$", ErrorMessage = "Dirección no válida")]
        public string direccion { get; set; }

        [Required(ErrorMessage = "Rellena este campo correctamente")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Correo electronico no válido")]
        public string email { get; set; }

        [Required(ErrorMessage = "Rellena este campo correctamente")]
        [RegularExpression(@"^(6|7)[0-9]{8}$", ErrorMessage = "Teléfono móvil no válido")]
        public int telefono { get; set; }

        [Required(ErrorMessage = "Rellena este campo correctamente")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "La contraseña tiene que tener un mínimo de 8 caracteres e incluir mayúscula y minúscula")]
        public string contraseña {get; set; }

    }
}
