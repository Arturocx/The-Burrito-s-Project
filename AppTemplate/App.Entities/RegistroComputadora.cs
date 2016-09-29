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
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdComputadora { get; set; }
        public DateTime FechaHoraInicio  { get; set; }
        public DateTime FechaHoraFinal { get; set; }
    }
}
