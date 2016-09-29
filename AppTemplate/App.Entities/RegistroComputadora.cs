using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    public class RegistroComputadora
    {
        [Key]
        public int ID { get; set; }
        public int IDAlumno { get; set; }
        public int IDComputadora { get; set; }
        public DateTime FechaHoraInicio  { get; set; }
        public DateTime FechaHoraFinal { get; set; }
    }
}
