using CapaSOPORTE;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Vista.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Colabora()
        {
            return View();
        }

        public IActionResult SobreNosotros()
        {
            return View();
        }
        public IActionResult IniciarSesion()
        {
            ViewData["Test"] = "jiji";
            return View();
        }
    }
}