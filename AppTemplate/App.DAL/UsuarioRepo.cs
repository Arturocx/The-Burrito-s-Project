using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class UsuarioRepo
    {
        private AppDBContext _Contexto;
        
        public UsuarioRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar(Usuario Usuario)
        {
            _Contexto.Usuario.Add(Usuario);
            _Contexto.SaveChanges();
        }
        
        public void Borrar(Usuario Usuario)
        {
            _Contexto.Usuario.Remove(Usuario);
            _Contexto.SaveChanges();
        }

        //select * front Usuario orden by Nombre
        public List<Usuario> TraerTodo()
        {
            return _Contexto.Usuario.OrderBy(x => x.Nombre).ToList();

        }
        //select * from Usuario where Id = 3
        public Usuario TraerPorId(int id)
        {
            return _Contexto.Usuario.FirstOrDefault(x => x.Id == id);
        }
    }
}
