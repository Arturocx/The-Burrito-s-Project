using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class LibroController : Controller
    {
        private LibroBLL _libroBll;
        private Libro _libroEntity;

        public LibroController()
        {
            _libroBll = new LibroBLL();
            _libroEntity = new Libro();
        }

        //
        // GET: /Libro/
        public ActionResult Index()
        {
            _libroEntity.Nombre = "Algebra de Baldor";
            _libroEntity.Disponible = "Disponible";
            _libroEntity.Materia = "MATEMATICAS";
            _libroEntity.Detalles = "NUEVO";
            _libroBll.Agregar(_libroEntity);

            return View();
        }
	}
}