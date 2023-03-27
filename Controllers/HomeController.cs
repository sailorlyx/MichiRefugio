using MichiRefugio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MichiRefugio.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
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

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesion(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensaje = "ta bien c:";
                return View("Index");
            }
            else
            {
                ViewBag.Mensaje = "ta mal :c";
                return View("Index", usuarioModel);
            }

        }

        public IActionResult PaginaSanson()
        {
            return View();
        }

        public IActionResult PaginaSombra()
        {
            return View();
        }

        public IActionResult PaginaKuma()
        {
            return View();
        }

        public IActionResult PaginaOnyx()
        {
            return View();
        }

        public IActionResult PaginaTupu()
        {
            return View();
        }

        public IActionResult PaginaCatra()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}