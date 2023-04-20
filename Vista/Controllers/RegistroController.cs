using CapaSOPORTE;
using Microsoft.AspNetCore.Mvc;

namespace Vista.Controllers
{
    public class RegistroController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearUsuario(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                var nuevoUsuario = new UsuarioModel //preguntar :(((
            {
                nombre = usuario.nombre,
                apellido = usuario.apellido,
                apellido2 = usuario.apellido2,
                email = usuario.email,
                contraseña = usuario.contraseña,
                telefono = usuario.telefono,
                //admin = usuario.admin .... esto no hace falta en verda??
            };

                //Usuario.Add(usuario); ...........asi igual no es :p
                //guardar cambios (mirar internet o preguntar)

                return RedirectToAction("Index", "Home");

            }

            return View(usuario);
        }


    }
}
