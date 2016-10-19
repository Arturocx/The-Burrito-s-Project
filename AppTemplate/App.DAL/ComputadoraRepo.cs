using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class ComputadoraRepo
    {
        private AppDBContext _Contexto;
        
        public ComputadoraRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar(Computadora Computadora)
        {
            _Contexto.Computadora.Add(Computadora);
            _Contexto.SaveChanges();
        }
        
        public void Borrar(Computadora Computadora)
        {
            _Contexto.Computadora.Remove(Computadora);
            _Contexto.SaveChanges();
        }

        //select * front Computadora orden by NoCubiculo
        public List<Computadora> TraerTodo()
        {
            return _Contexto.Computadora.OrderBy(x => x.NoCubiculo).ToList();

        }
        //select * from Computadora where Id = 3
        public Computadora TraerPorId(int id)
        {
            return _Contexto.Computadora.FirstOrDefault(x => x.Id == id);
        }
    }
}
