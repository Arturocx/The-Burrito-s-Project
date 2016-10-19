using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class AlumnoController : Controller
    {
        private AlumnoBLL _alumnoBll;
        private Alumno _alumnoEntity;

        public AlumnoController()
        {
            _alumnoBll = new AlumnoBLL();
            _alumnoEntity = new Alumno();
        }

        //
        // GET: /Alumno/
        public ActionResult Index()
        {
            _alumnoEntity.NoControl = 123456;
            _alumnoEntity.Grupo = "5DM";
            _alumnoEntity.Nombre = "Miguel";
            _alumnoEntity.Apellido = "Vargas";
            _alumnoEntity.Foto = "https://scontent.ftij1-1.fna.fbcdn.net/v/t1.0-9/14446236_1168723523194498_8177993366894271305_n.jpg?oh=9f5c1914a2ff480255c97018fcf77412&oe=58AB50E8";
            _alumnoEntity.Bloqueado = false;
            _alumnoBll.Agregar(_alumnoEntity);

            return View();
        }
	}
}