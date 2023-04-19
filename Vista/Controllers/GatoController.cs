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
            ObtenerGustas();
            return View(listas);
        }

        public ActionResult FichaGato(int id) 
        {
            ObtenerGato(id);
            ObtenerGusta(id);
            ObtenerOdia(id);
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

        public void ObtenerGustas()
        {
            listas.listaGustas = DOM_GUSTA.ObtenerGustas();
        }

        public void ObtenerGusta(int id)
        {
            listas.listaGustas = DOM_GUSTA.ObtenerGusta(id);
        }

        public void ObtenerOdias()
        {
            listas.listaOdias = DOM_ODIA.ObtenerOdias();
        }
        public void ObtenerOdia(int id)
        {
            listas.listaOdias = DOM_ODIA.ObtenerOdia(id);
        }
        public void ObtenerUsuarios()
        {
            listas.listaUsuarios = DOM_USUARIO.ObtenerUsuarios();
        }
        public void ObtenerUsuario(int id)
        {
            listas.listaUsuarios = DOM_USUARIO.ObtenerUsuario(id);
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
