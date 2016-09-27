using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class RegistroComputadora
    {
        public int ID { get; set; }
        public int IDAlumno { get; set; }
        public int IDComputadora { get; set; }
        public DateTime FechaHoraInicio  { get; set; }
        public DateTime FechaHoraFinal { get; set; }

    }
}
