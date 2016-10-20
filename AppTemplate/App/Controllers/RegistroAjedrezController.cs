using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class RegistroAjedrezController : Controller
    {
        private RegistroAjedrezBLL _RegistroAjedrezBll;
        private RegistroAjedrez _RegistroAjedrezEntity;

        public RegistroAjedrezController()
        {
            _RegistroAjedrezBll = new RegistroAjedrezBLL();
            _RegistroAjedrezEntity = new RegistroAjedrez();
        }

        //
        // GET: /Registro Ajedrez/
        public ActionResult Index()
        {
            _RegistroAjedrezEntity.FechaHoraInicio = DateTime.Now;
            _RegistroAjedrezEntity.FechaHoraFinal = new DateTime(2016,10,19);
            _RegistroAjedrezBll.Agregar(_RegistroAjedrezEntity);
            return View();
        }

    }
}