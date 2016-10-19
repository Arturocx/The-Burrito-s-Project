using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class ComputadoraBLL
    {
        private ComputadoraRepo _computadoraRepo;

        public ComputadoraBLL()
        {
            _computadoraRepo = new ComputadoraRepo();
        }

        public void Agregar(Computadora Computadora)
        {
            _computadoraRepo.Agregar(Computadora);
        }

        public void Borrar(Computadora Computadora)
        {
            _computadoraRepo.Borrar(Computadora);
        }

        public List<Computadora> TraerTodo()
        {
            return _computadoraRepo.TraerTodo();
        }

        public Computadora TraerPorId(int id)
        {
            return _computadoraRepo.TraerPorId(id);
        }
    }
}
