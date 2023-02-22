using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MichiRefugio.Models
{
    public class FormularioAdopcionModel
    {
        [Required(ErrorMessage = "Rellena este campo correctamente")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Rellena este campo correctamente")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "Rellena este campo correctamente")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Correo electronico no válido")]
        public string email { get; set; }

        [Required(ErrorMessage = "Rellena este campo correctamente")]
        [RegularExpression(@"^(6|7)[0-9]{8}$", ErrorMessage = "Teléfono móvil no válido")]
        public int telefono { get; set; }

    }
}
