using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class AlumnoRepo
    {
        private AppDBContext _Contexto;
        
        public AlumnoRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar(Alumno Alumnos)
        {
            _Contexto.Alumno.Add(Alumnos);
            _Contexto.SaveChanges();
        }
        
        public void Borrar(Alumno Alumnos)
        {
            _Contexto.Alumno.Remove(Alumnos);
            _Contexto.SaveChanges();
        }

        //select * front Alumno orden by nocontrol
        public List<Alumno> TraerTodo()
        {
            return _Contexto.Alumno.OrderBy(x => x.NoControl).ToList();

        }
        //select * from alumno where Id = 3
        public Alumno TraerPorId(int id)
        {
            return _Contexto.Alumno.FirstOrDefault(x => x.Id == id);
        }
    }
}
