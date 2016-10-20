using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class RegistroLibroController : Controller
    {
        private RegistroLibroBLL _RegistroLibrobll;
        private Registro_de_Libro _RegistroLibroEntity;


        public RegistroLibroController()
        {
            _RegistroLibrobll = new RegistroLibroBLL();
            _RegistroLibroEntity = new Registro_de_Libro();
        }


       //
       // GET: /Registro Libro/

        public ActionResult Index()
        {
            _RegistroLibroEntity.FechadeSalida = DateTime.Now;
            _RegistroLibroEntity.FechaLimite = new DateTime(2016, 10, 23);
            _RegistroLibroEntity.FechadeEntrega = new DateTime(2016, 10, 21);
            _RegistroLibroEntity.DetallesdelLibro = "En Buenas Condiciones";
            _RegistroLibrobll.Agregar(_RegistroLibroEntity);
           return View();
        }
    }
    
}