using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class RegistroLibroRepo
    {
        private AppDBContext _Contexto;
        
        public RegistroLibroRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar(Registro_de_Libro RegistroLibro)
        {
            _Contexto.RegistroLibro.Add(RegistroLibro);
            _Contexto.SaveChanges();
        }
        
        public void Borrar(Registro_de_Libro RegistroLibro)
        {
            _Contexto.RegistroLibro.Remove(RegistroLibro);
            _Contexto.SaveChanges();
        }

        //select * front Registro_de_Libro orden by IdLibro
        public List<Registro_de_Libro> TraerTodo()
        {
            return _Contexto.RegistroLibro.OrderBy(x => x.IdLibro).ToList();

        }
        //select * from Registro_de_Libro where Id = 3
        public Registro_de_Libro TraerPorId(int id)
        {
            return _Contexto.RegistroLibro.FirstOrDefault(x => x.Id == id);
        }
    }
}
