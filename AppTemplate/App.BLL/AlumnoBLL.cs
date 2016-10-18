using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class AlumnoBLL
    {
        private AlumnoRepo _alumnoRepo;

        public AlumnoBLL()
        {
            _alumnoRepo = new AlumnoRepo();
        }

        public void Agregar(Alumno alumno)
        {
            _alumnoRepo.Agregar(alumno);
        }


        public void Borrar(Alumno alumno)
        {
            _alumnoRepo.Borrar(alumno);
        }

        public List<Alumno> TraerTodo()
        {
            return _alumnoRepo.TraerTodo();
        }

        public Alumno TraerPorId(int id)
        {
            return _alumnoRepo.TraerPorId(id);
        }
    }
}
