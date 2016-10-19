using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class AjedrezController : Controller
    {
        private AjedrezBLL _ajedrezBll;
        private Ajedrez _ajedrezEntity;

        public AjedrezController()
        {
            _ajedrezBll = new AjedrezBLL();
            _ajedrezEntity = new Ajedrez();
        }

        //
        // GET: /Ajedrez/
        public ActionResult Index()
        {
            _ajedrezEntity.NoMesa = 1;
            _ajedrezBll.Agregar(_ajedrezEntity);

            return View();
        }
	}
}