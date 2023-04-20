using CapaSOPORTE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Vista.Controllers
{
    public class InicioSesionController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult ValidarUsuario(string email, string contraseña)
        //{
        //    bool usuarioValido = UsuarioModel.ValidarUsuario(email, contraseña);

        //    if (usuarioValido)
        //    {
        //        HttpContext.Session.SetString("email", email);
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ViewBag.Mensaje = "Email y/o contraseña incorrectos.";
        //        return View("Index");
        //    }
        //}

        //public ActionResult CerrarSesion()
        //{
        //    HttpContext.Session.Clear();
        //    return RedirectToAction("Index", "Home");
        //}
    }
}

