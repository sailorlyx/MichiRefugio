using Microsoft.AspNetCore.Mvc;

namespace Vista.Controllers
{
    public class RegistrarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(string nombre, string apellido, string apellido2, string email, string contraseña, string telefono)
        {
            return View();
        }
    }
}
