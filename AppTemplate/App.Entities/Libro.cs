using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libros
{
    public class Libro
    {
        
        

        public int LibroID { get; set; }
        public string Nombre { get; set; }
        public string Disponible { get; set; }
        public DateTime FechadePublicacion { get; set; }
        public byte[] Photo { get; set; }
        public string Materia { get; set; }
        public string Detalles { get; set; }


    }
}