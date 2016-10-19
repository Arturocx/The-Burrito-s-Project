using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class RegistroComputadoraBLL
    {
        private RegistroComputadoraRepo _registrocomputadoraRepo;

        public RegistroComputadoraBLL()
        {
            _registrocomputadoraRepo = new RegistroComputadoraRepo();
        }

        public void Agregar(RegistroComputadora RegistroComputadora)
        {
            _registrocomputadoraRepo.Agregar(RegistroComputadora);
        }


        public void Borrar(RegistroComputadora RegistroComputadora)
        {
            _registrocomputadoraRepo.Borrar(RegistroComputadora);
        }

        public List<RegistroComputadora> TraerTodo()
        {
            return _registrocomputadoraRepo.TraerTodo();
        }

        public RegistroComputadora TraerPorId(int id)
        {
            return _registrocomputadoraRepo.TraerPorId(id);
        }
    }
}
