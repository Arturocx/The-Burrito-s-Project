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
            
            var Alumnos = _alumnoBll.TraerTodo(); 

            return View(Alumnos);
        }

        public ActionResult Agregar()
        {

            return View();
        }

        public ActionResult AgregarAlumno(int noControl, string nombre, string apellido, string grupo, string foto)
        {
            _alumnoEntity.NoControl = noControl;
            _alumnoEntity.Grupo = grupo;
            _alumnoEntity.Nombre = nombre;
            _alumnoEntity.Apellido = apellido;
            _alumnoEntity.Foto = foto;
            _alumnoEntity.Bloqueado = false;
            _alumnoBll.Agregar(_alumnoEntity);
            return View();
        }

        public ActionResult Detalle(int Id)
        {
            var alumno = _alumnoBll.TraerPorId(Id);
            return View(alumno);
        }
	}
}