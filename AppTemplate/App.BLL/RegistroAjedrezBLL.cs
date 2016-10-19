using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class RegistroAjedrezBLL
    {
        private RegistroAjedrezRepo _registroajedrezRepo;

        public RegistroAjedrezBLL()
        {
            _registroajedrezRepo = new RegistroAjedrezRepo();
        }

        public void Agregar(RegistroAjedrez RegistroAjedrez)
        {
            _registroajedrezRepo.Agregar(RegistroAjedrez);
        }


        public void Borrar(RegistroAjedrez RegistroAjedrez)
        {
            _registroajedrezRepo.Borrar(RegistroAjedrez);
        }

        public List<RegistroAjedrez> TraerTodo()
        {
            return _registroajedrezRepo.TraerTodo();
        }

        public RegistroAjedrez TraerPorId(int id)
        {
            return _registroajedrezRepo.TraerPorId(id);
        }
    }
}
