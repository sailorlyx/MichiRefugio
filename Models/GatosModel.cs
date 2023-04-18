using System.ComponentModel.DataAnnotations;

namespace MichiRefugio.Models
{
    public class GatosModel
    {
        [Required(ErrorMessage = "Required")]
        public int id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Required")]
        public int edad { get; set; }

        [Required(ErrorMessage = "Required")]
        public char genero { get; set; }

        [Required(ErrorMessage = "Required")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool adoptado { get; set; }

        [Required(ErrorMessage = "Required")]
        public string foto { get; set; }
    }
}
