using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class AjedrezRepo
    {
        private AppDBContext _Contexto;

        public AjedrezRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar(Ajedrez Ajedrez)
        {
            _Contexto.Ajedrez.Add(Ajedrez);
            _Contexto.SaveChanges();
        }
        
        public void Borrar(Ajedrez Ajedrez)
        {
            _Contexto.Ajedrez.Remove(Ajedrez);
            _Contexto.SaveChanges();
        }

        //select * front Ajedrez orden by NoMesa
        public List<Ajedrez> TraerTodo()
        {
            return _Contexto.Ajedrez.OrderBy(x => x.NoMesa).ToList();

        }
        //select * from Ajedrez where Id = 3
        public Ajedrez TraerPorId(int id)
        {
            return _Contexto.Ajedrez.FirstOrDefault(x => x.Id == id);
        }
    }
}
