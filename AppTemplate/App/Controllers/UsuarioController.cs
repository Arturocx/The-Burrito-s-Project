using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioBLL _usuarioBll;
        private Usuario _usuarioEntity;

        public UsuarioController()
        {
            _usuarioBll = new UsuarioBLL();
            _usuarioEntity = new Usuario();
        }

        //
        // GET: /Usuario/
        public ActionResult Index()
        {
            _usuarioEntity.Nombre = "Christopher";
            _usuarioEntity.Contrasena = "washoywasha";
            _usuarioEntity.Username = "ArturitoMP";
            _usuarioEntity.APaterno = "Morales";
            _usuarioEntity.AMaterno = "Padilla";
            _usuarioBll.Agregar(_usuarioEntity);

            return View();
        }
	}
}