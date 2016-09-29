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
        /// Identificador de la tabla Registro Computadora
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Fecha y Hora del inicio
        /// </summary>
        public DateTime FechaHoraInicio  { get; set; }
        /// <summary>
        /// Fecha y Hora del inicio
        /// </summary>
        public DateTime FechaHoraFinal { get; set; }
        
        /// <summary>
        /// Llave foranea de Alumno
        /// </summary>
        public int IdAlumno { get; set; }
        public Alumno Alumno { get; set; }
        /// <summary>
        /// Llave foranea de Computadora
        /// </summary>
        public int IdComputadora { get; set; }
        public Computadora Computadora { get; set; }
    }
}
