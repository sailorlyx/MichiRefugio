using CapaSOPORTE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace Vista.Controllers
{
    public class InicioSesionController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string contraseña)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
        }
    }
}

