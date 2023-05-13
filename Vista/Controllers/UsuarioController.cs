using CapaDOM;
using CapaSOPORTE;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Vista.Controllers;

namespace Vista.Controllers
{
    public class UsuarioController : BaseController
    {
        public ActionResult IniciarSesionView()
        {
            return View("IniciarSesion");
        }

        public ActionResult RegistroView()
        {
            return View("Registro");
        }

        public ActionResult PerfilUsuarioView()
        {
            return View("PerfilUsuario");
        }

        public ActionResult ObtenerUsuarios()
        {
            listas.listaUsuarios = DOM_USUARIO.ObtenerUsuarios();
            return View();
        }

        public ActionResult ObtenerUsuario(int id)
        {
            listas.listaUsuarios = DOM_USUARIO.ObtenerUsuario(id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IniciarSesion(InicioSesionModel usu)
        {
            if (ModelState.IsValid)
            {
                if (ValidarUsuario(usu.email, usu.contraseña))
                {
                    ComprobarAdminPorEmail();
                    var admin = ComprobarAdminPorEmail();
                    HttpContext.Session.SetString("NombreEmail", usu.email);
                    HttpContext.Session.SetString("admin", admin.ToString());
                    return RedirectToAction("Index", "Gato");
                }
                else
                {
                    return View("IniciarSesion", usu);
                }

            }
            else
            {

                return View("IniciarSesion", usu);
            }
        }

        [HttpPost]
        public ActionResult Registrar(UsuarioModel usuregistro)
        {
            string mensaje1 = "Este usuario ya existe o no es correcto, por favor, asegúrese de que sus datos son válidos.";
            string mensaje2 = "¡Usuario creado con éxito!";
         
            if (ModelState.IsValid)
            {
                ConseguirUsuarioPorEmail(usuregistro.email);

                if (listas.listaUsuarios.Count == 0)
                {
                    ViewBag.Message = mensaje2;
                    DOM_USUARIO.RegistrarUsuario(usuregistro.nombre, usuregistro.apellido, usuregistro.apellido2, usuregistro.email, usuregistro.contraseña, usuregistro.telefono);
                    return RedirectToAction("Index", "Gato");
                }
                else
                {
                    ViewBag.Message = mensaje2;
                    return View("Registro", usuregistro);
                }
               
            }
            else
            {
                ViewBag.Message = mensaje1;
                return View();
            }
            
        }

        public bool ValidarUsuario(string email, string contraseña)
        {
            ConseguirUsuarioPorEmail(email);

            if (listas.listaUsuarios.Count > 0)
            {
                if (Utilidades.ComprobarContra(contraseña, listas.listaUsuarios[0].contraseña))
                {
                    return true;
                }
            }

            return false;
        }

        public void ConseguirUsuarioPorEmail(string email)
        {
            listas.listaUsuarios = DOM_USUARIO.ConseguirUsuarioPorEmail(email);
        }

        public ActionResult CerrarSesion()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Gato");
        }

        private bool ComprobarAdminPorEmail()
        {
            if (listas.listaUsuarios[0].admin) { 
                return true; 
            } else
            {
                return false;
            }
        }
    }
}
