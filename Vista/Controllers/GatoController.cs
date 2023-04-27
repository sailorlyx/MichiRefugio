using Microsoft.AspNetCore.Mvc;
using CapaSOPORTE;
using CapaDOM;

namespace Vista.Controllers
{
    
    public class GatoController : Controller
    {
        Listas listas = new Listas();
        public ActionResult Index()
        {
            ObtenerGatos();
            ViewBag.EmailUsuario = HttpContext.Session.GetString("NombreEmail");

            return View(listas);
        }

        public ActionResult FichaGato(int id) 
        {
            ObtenerGato(id);
            return View(listas);
        }

        public void ObtenerGatos()
        {
            listas.listaGatos = DOM_GATO.ObtenerGatos();
        }
        public void ObtenerGato(int id)
        {
            listas.listaGatos = DOM_GATO.ObtenerGato(id);
        }

    }
}
