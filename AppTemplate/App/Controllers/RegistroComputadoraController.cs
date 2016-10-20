using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class RegistroComputadoraController : Controller
    {
        private RegistroComputadoraBLL _RegistroComputadoraBll;
        private RegistroComputadora _RegistroComputadoraEntity;

        public RegistroComputadoraController()
        {
            _RegistroComputadoraBll = new RegistroComputadoraBLL();
            _RegistroComputadoraEntity = new RegistroComputadora();
        }

        //
        // GET: /Registro Computadora/

        public ActionResult Index()
        {
            _RegistroComputadoraEntity.FechaHoraInicio = DateTime.Now;
            _RegistroComputadoraEntity.FechaHoraFinal = new DateTime(2016,10,19);
            _RegistroComputadoraBll.Agregar(_RegistroComputadoraEntity);
            return View();
        }

    }
}