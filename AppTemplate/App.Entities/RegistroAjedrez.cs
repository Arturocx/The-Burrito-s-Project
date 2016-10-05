using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    public class RegistroAjedrez
    {
        [Key]
        public int Id { get; set; }
       
        /// <summary>
        /// Fecha y Hora inicio
        /// </summary>
        public DateTime FechaHoraInicio { get; set; }
        /// <summary>
        /// Fecha y Hora Final
        /// </summary>
        public DateTime FechaHoraFinal { get; set; }

        /// <summary>
        /// Llave foranea de Alumno
        /// </summary>
        public int IdAlumno { get; set; }
        public Alumno Alumno { get; set; }
        /// <summary>
        /// Llave foranea de Ajedrez
        /// </summary>
        public int IdAjedrez { get; set; }
        public Ajedrez Ajedrez { get; set; }
    }
}
