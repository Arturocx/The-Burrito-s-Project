using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class LibroRepo
    {
        private AppDBContext _Contexto;
        
        public LibroRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar(Libro Libro)
        {
            _Contexto.Libro.Add(Libro);
            _Contexto.SaveChanges();
        }
        
        public void Borrar(Libro Libro)
        {
            _Contexto.Libro.Remove(Libro);
            _Contexto.SaveChanges();
        }

        //select * front Libro orden by Materia
        public List<Libro> TraerTodo()
        {
            return _Contexto.Libro.OrderBy(x => x.Materia).ToList();

        }
        //select * from Libro where Id = 3
        public Libro TraerPorId(int id)
        {
            return _Contexto.Libro.FirstOrDefault(x => x.Id == id);
        }
    }
}
