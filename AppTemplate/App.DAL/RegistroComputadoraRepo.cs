using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class RegistroComputadoraRepo
    {
        private AppDBContext _Contexto;
        
        public RegistroComputadoraRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar(RegistroComputadora RegistroComputadora)
        {
            _Contexto.RegistroComputadora.Add(RegistroComputadora);
            _Contexto.SaveChanges();
        }
        
        public void Borrar(RegistroComputadora RegistroComputadora)
        {
            _Contexto.RegistroComputadora.Remove(RegistroComputadora);
            _Contexto.SaveChanges();
        }

        //select * front RegistroComputadora orden by IdComputadora
        public List<RegistroComputadora> TraerTodo()
        {
            return _Contexto.RegistroComputadora.OrderBy(x => x.IdComputadora).ToList();

        }
        //select * from RegistroComputadora where Id = 3
        public RegistroComputadora TraerPorId(int id)
        {
            return _Contexto.RegistroComputadora.FirstOrDefault(x => x.Id == id);
        }
    }
}
