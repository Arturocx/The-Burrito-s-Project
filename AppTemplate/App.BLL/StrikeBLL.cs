using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class StrikeBLL
    {
        private StrikeRepo _strikeRepo;

        public StrikeBLL()
        {
            _strikeRepo = new StrikeRepo();
        }

        public void Agregar(Strikes Strike)
        {
            _strikeRepo.Agregar(Strike);
        }


        public void Borrar(Strikes Strike)
        {
            _strikeRepo.Borrar(Strike);
        }

        public List<Strikes> TraerTodo()
        {
            return _strikeRepo.TraerTodo();
        }

        public Strikes TraerPorId(int id)
        {
            return _strikeRepo.TraerPorId(id);
        }
    }
}
