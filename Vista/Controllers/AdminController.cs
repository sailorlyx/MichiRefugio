using CapaDOM; 
using CapaSOPORTE;
using Microsoft.AspNetCore.Mvc;
using System.Web;
namespace Vista.Controllers
{
    public class AdminController : Controller
    {
        Listas listas = new Listas();
        public ActionResult PanelAdmin()
        {
            ObtenerUsuarios();
            ObtenerGatos();
            ObtenerFormularios();
            return View(listas);
        }

        public void ObtenerGatos()
        {
            listas.listaGatos = DOM_GATO.ObtenerGatos();
        }

        public ActionResult ObtenerUsuarios()
        {
            listas.listaUsuarios = DOM_USUARIO.ObtenerUsuarios();
            return View();
        }

        public void ObtenerFormularios()
        {
            listas.listaFormularios = DOM_FORMULARIO.ObtenerFormularios();
        }


    }
}
