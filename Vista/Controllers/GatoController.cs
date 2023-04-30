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

        [HttpPost]
        public ActionResult GuardarFormulario(Listas lista)
        {
            string emailLogueado = HttpContext.Session.GetString("NombreEmail");
            
            if (emailLogueado != null)
            {
                UsuarioModel usuActual = DOM_USUARIO.ConseguirUsuarioPorEmail(emailLogueado)[0];
                lista.formularioUsu.nombre = usuActual.nombre;
                lista.formularioUsu.apellido = usuActual.apellido;
                lista.formularioUsu.apellido2 = usuActual.apellido2;
                lista.formularioUsu.email = usuActual.email;
                lista.formularioUsu.telefono = usuActual.telefono;
            }

            DOM_FORMULARIO.GuardarFormulario(listas.formularioUsu);
            return RedirectToAction("Index", "Gato");
        }

    }
}
