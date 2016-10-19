using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class AjedrezBLL
    {
        private AjedrezRepo _ajedrezRepo;

        public AjedrezBLL()
        {
            _ajedrezRepo = new AjedrezRepo();
        }

        public void Agregar(Ajedrez ajedrez)
        {
            _ajedrezRepo.Agregar(ajedrez);
        }


        public void Borrar(Ajedrez ajedrez)
        {
            _ajedrezRepo.Borrar(ajedrez);
        }

        public List<Ajedrez> TraerTodo()
        {
            return _ajedrezRepo.TraerTodo();
        }

        public Ajedrez TraerPorId(int id)
        {
            return _ajedrezRepo.TraerPorId(id);
        }
    }
}
