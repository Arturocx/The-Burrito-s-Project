using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Libros
{
    public class Registro_de_Libro
    {
        [Key]
        public int Id { get; set; }
        public int Alumno { get; set; }
        public DateTime FechadeSalida { get; set; }
        public DateTime FechaLimite { get; set; }
        public DateTime FechadeEntrega{ get; set; }
        public string DetallesdelLibro { get; set; }
    }
}