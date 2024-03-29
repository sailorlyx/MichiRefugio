﻿using CapaACCESODATOS;
using CapaDOM; 
using CapaSOPORTE;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
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

        public ActionResult ModificarGato(int id)
        {
            List<GatoModel> resultado = DOM_GATO.ObtenerGato(id);
            GatoModel? gato = resultado.FirstOrDefault();

            return View(gato);
        }

        public ActionResult GuardarModiGato(GatoModel meow)
        {
            DOM_GATO.ModificarGato(meow);

            return View("ModificarGato");
        }

        public ActionResult ModificarUsuario(int id)
        {
            List<UsuarioModel> resultado = DOM_USUARIO.ObtenerUsuario(id);
            UsuarioModel? usu = resultado.FirstOrDefault();

            return View(usu);
        }

        public ActionResult GuardarModiUsuario(UsuarioModel usuario)
        {
            DOM_USUARIO.ModificarUsuario(usuario);

            return RedirectToAction("PanelAdmin", "Admin");

        }

        public ActionResult EliminarUsuario(int id)
        {
            DOM_USUARIO.EliminarUsuario(id);
            return RedirectToAction("PanelAdmin", "Admin");

        }

        public ActionResult EliminarFormu(int id)
        {
            DOM_FORMULARIO.EliminarFormulario(id);
            return RedirectToAction("PanelAdmin", "Admin");
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
