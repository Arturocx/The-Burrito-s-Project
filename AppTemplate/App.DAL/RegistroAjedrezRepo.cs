using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class RegistroAjedrezRepo
    {
        private AppDBContext _Contexto;
        
        public RegistroAjedrezRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar(RegistroAjedrez RegistroAjedrez)
        {
            _Contexto.RegistroAjedrez.Add(RegistroAjedrez);
            _Contexto.SaveChanges();
        }
        
        public void Borrar(RegistroAjedrez RegistroAjedrez)
        {
            _Contexto.RegistroAjedrez.Remove(RegistroAjedrez);
            _Contexto.SaveChanges();
        }

        //select * front RegistroAjedrez orden by IdAjedrez
        public List<RegistroAjedrez> TraerTodo()
        {
            return _Contexto.RegistroAjedrez.OrderBy(x => x.IdAjedrez).ToList();

        }
        //select * from RegistroAjedrez where Id = 3
        public RegistroAjedrez TraerPorId(int id)
        {
            return _Contexto.RegistroAjedrez.FirstOrDefault(x => x.Id == id);
        }
    }
}
