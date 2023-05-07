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

        public ActionResult ModificarGato()
        {
            return View();
        }
        public ActionResult ModificarUsuario()
        {
            return View();
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

        #region CRUD

        //public void ModificarGato()
        //{
        //    listas.listaGatos = DOM_GATO.ModificarGato();
        //}

        //public void EliminarGato()
        //{
        //    listas.listaGatos = DOM_GATO.EliminarGato();
        //}

        //public void ModificarUsuario()
        //{
        //    listas.listaGatos = DOM_USUARIO.ModificarUsuario();
        //}

        //public void EliminarUsuario()
        //{
        //    listas.listaGatos = DOM_USUARIO.EliminarUsuario();
        //}

        //public void EliminarFormulario()
        //{
        //    listas.listaGatos = DOM_FORMULARIO.EliminarFormulario();
        //}

        #endregion
    }
}
