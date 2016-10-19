using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class RegistroLibroBLL
    {
        private RegistroLibroRepo _registrolibroRepo;

        public RegistroLibroBLL()
        {
            _registrolibroRepo = new RegistroLibroRepo();
        }

        public void Agregar(Registro_de_Libro RegistroLibro)
        {
            _registrolibroRepo.Agregar(RegistroLibro);
        }


        public void Borrar(Registro_de_Libro RegistroLibro)
        {
            _registrolibroRepo.Borrar(RegistroLibro);
        }

        public List<Registro_de_Libro> TraerTodo()
        {
            return _registrolibroRepo.TraerTodo();
        }

        public Registro_de_Libro TraerPorId(int id)
        {
            return _registrolibroRepo.TraerPorId(id);
        }
    }
}
