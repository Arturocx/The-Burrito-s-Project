using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class StrikeController : Controller
    {
        private StrikeBLL _strikeBll;
        private Strikes _strikeEntity;

        public StrikeController()
        {
            _strikeBll = new StrikeBLL();
            _strikeEntity = new Strikes();
        }

        //
        // GET: /Strike/
        public ActionResult Index()
        {
            _strikeEntity.Motivo = "Maltrato de libro";
            _strikeBll.Agregar(_strikeEntity);

            return View();
        }
	}
}