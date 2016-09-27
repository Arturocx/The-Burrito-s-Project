using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libros
{
    public class Registro_de_Libro
    {
        public int LibroID { get; set; }
        public int IDAlumno { get; set; }
        public DateTime FechadeSalida { get; set; }
        public DateTime FechaLimite { get; set; }
        public DateTime FechadeEntrega{ get; set; }
        public string DetallesdelLibro { get; set; }
    }
}