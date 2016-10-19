using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class StrikeRepo
    {
        private AppDBContext _Contexto;
        
        public StrikeRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar(Strikes Strikes)
        {
            _Contexto.Strikes.Add(Strikes);
            _Contexto.SaveChanges();
        }
        
        public void Borrar(Strikes Strikes)
        {
            _Contexto.Strikes.Remove(Strikes);
            _Contexto.SaveChanges();
        }

        //select * front Strikes orden by Motivo
        public List<Strikes> TraerTodo()
        {
            return _Contexto.Strikes.OrderBy(x => x.Motivo).ToList();

        }
        //select * from Strikes where Id = 3
        public Strikes TraerPorId(int id)
        {
            return _Contexto.Strikes.FirstOrDefault(x => x.Id == id);
        }
    }
}
