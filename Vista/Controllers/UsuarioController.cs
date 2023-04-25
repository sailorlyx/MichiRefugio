using CapaDOM;
using CapaSOPORTE;
using Microsoft.AspNetCore.Mvc;
using System.Web;
//using System.Web.Security;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IniciarSesion(InicioSesionModel usu)
        {
            if (ModelState.IsValid)
            {
                if (ValidarUsuario(usu.email, usu.contraseña))
                {
                    HttpContext.Session.SetString("NombreEmail", usu.email);
                    return RedirectToAction("Index", "Gato");
                }
                else
                {
                    ViewBag.Message = "Usuario no encontrado";
                    return View("IniciarSesion", usu);
                }

            }
            else
            {
                ViewBag.Message = "Email y/o contraseña incorrectos";
                return View("IniciarSesion", usu);
            }
        }

        [HttpPost]
        public ActionResult Registrar(UsuarioModel usuregistro)
        {
            if (ModelState.IsValid)
            {
                ConseguirUsuarioPorEmail(usuregistro.email);

                if (listas.listaUsuarios.Count == 0)
                {
                    DOM_USUARIO.RegistrarUsuario(usuregistro.nombre, usuregistro.apellido, usuregistro.apellido2, usuregistro.email, usuregistro.contraseña, usuregistro.telefono);
                    return RedirectToAction("Index", "Gato");
                }
                else
                {
                    ViewBag.Message = "Este usuario ya existe, por favor, asegúrese de que sus datos son correctos.";
                    return View("Registro", usuregistro);
                }
               
            }
            else
            {
                ViewBag.Message = "¡Usuario creado con éxito!";
                return View("Registro");
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

    }
}
