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

        public void ObtenerUsuarios()
        {
            listas.listaUsuarios = DOM_USUARIO.ObtenerUsuarios();
        }

        public void ObtenerUsuario(int id)
        {
            listas.listaUsuarios = DOM_USUARIO.ObtenerUsuario(id);
        }

        public void ObtenerFormulario()
        {
            listas.listaFormulario = DOM_FORMULARIO.ObtenerFormulario();
        }

        public ActionResult Registro()
        {
            return View();
        }

        public ActionResult IniciarSesion()
        {
            return View();
        }
    }
}
