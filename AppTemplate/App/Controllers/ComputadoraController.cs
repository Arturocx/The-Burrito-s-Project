using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class ComputadoraController : Controller
    {
        private ComputadoraBLL _computadoraBll;
        private Computadora _computadoraEntity;

        public ComputadoraController()
        {
            _computadoraBll = new ComputadoraBLL();
            _computadoraEntity = new Computadora();
        }

        //
        // GET: /Computadora/
        public ActionResult Index()
        {
            _computadoraEntity.NoCubiculo = 5;
            _computadoraEntity.ModeloCompu = "PS511U-02WYJJ";
            _computadoraEntity.Status = "Bien";
            _computadoraBll.Agregar(_computadoraEntity);

            return View();
        }
	}
}