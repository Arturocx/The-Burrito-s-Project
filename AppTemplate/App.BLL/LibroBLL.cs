using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class LibroBLL
    {
        private LibroRepo _libroRepo;

        public LibroBLL()
        {
            _libroRepo = new LibroRepo();
        }

        public void Agregar(Libro Libro)
        {
            _libroRepo.Agregar(Libro);
        }


        public void Borrar(Libro Libro)
        {
            _libroRepo.Borrar(Libro);
        }

        public List<Libro> TraerTodo()
        {
            return _libroRepo.TraerTodo();
        }

        public Libro TraerPorId(int id)
        {
            return _libroRepo.TraerPorId(id);
        }
    }
}
