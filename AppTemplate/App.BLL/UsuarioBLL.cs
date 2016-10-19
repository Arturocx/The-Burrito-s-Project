using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class UsuarioBLL
    {
        private UsuarioRepo _usuarioRepo;

        public UsuarioBLL()
        {
            _usuarioRepo = new UsuarioRepo();
        }

        public void Agregar(Usuario Usuario)
        {
            _usuarioRepo.Agregar(Usuario);
        }


        public void Borrar(Usuario Usuario)
        {
            _usuarioRepo.Borrar(Usuario);
        }

        public List<Usuario> TraerTodo()
        {
            return _usuarioRepo.TraerTodo();
        }

        public Usuario TraerPorId(int id)
        {
            return _usuarioRepo.TraerPorId(id);
        }
    }
}
