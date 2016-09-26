using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    class RegistroAjedrez
    {
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdAjedrez { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFinal { get; set; }
    }
}
