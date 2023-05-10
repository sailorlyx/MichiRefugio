using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vista.Controllers;

namespace PruebasMichiRefu
{
    [TestClass]
    public class PruebaLogin
    {
        [TestMethod]
        public void TestInicioSesionValido()
        {
            var controller = new UsuarioController();
            var modelo = new InicioSesionModel
            {
                email = "holi@miaumiau.com",
                contraseña = "miaumiaumiau"
            };

            var resultado = controller.InicioSesion(modelo) as RedirectToActionResult;

            Assert.IsNotNull(resultado);
            Assert.AreEqual("Index", resultado.ActionName);
            Assert.AreEqual("Gato", resultado.ControllerName);
        }

        [TestMethod]
        public void TestInicioSesionInvalido()
        {
            var controller = new UsuarioController();
            var modelo = new InicioSesionModel
            {
                email = "usuario@correo.com",
                contraseña = "u"
            };

            var result = controller.IniciarSesion(modelo) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("IniciarSesion", result.ViewName);
            Assert.AreEqual("Usuario no encontrado o incorrecto", result.ViewBag.Message);
        }
    }
}
    }
}
