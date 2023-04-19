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

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult IniciarSesion()
        {
            return View();
        }

        //public ActionResult IniciarSesion(UsuarioModel UsuarioModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ViewBag.Mensaje = "¡Bienvenid@!";
        //        return View();
        //    }
        //    else
        //    {
        //        ViewBag.Mensaje = "Correo electrónico y/o contraseña incorrectos";
        //        return View("IniciarSesion", UsuarioModel);
        //    }

        //}

        //public IActionResult PaginaSanson()
        //{
        //    return View();
        //}

        //public IActionResult PaginaSombra()
        //{
        //    return View();
        //}

        //public IActionResult PaginaKuma()
        //{
        //    return View();
        //}

        //public IActionResult PaginaOnyx()
        //{
        //    return View();
        //}

        //public IActionResult PaginaTupu()
        //{
        //    return View();
        //}

        //public IActionResult PaginaCatra()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}