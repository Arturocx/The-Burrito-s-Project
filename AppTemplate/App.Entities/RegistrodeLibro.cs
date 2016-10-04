using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace App.Entities

{
    public class Registro_de_Libro
    {
 
        /// <summary>
        /// Identificador de la tabla Registro Libro
        /// </summary>
        
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Fecha y Hora de Salida
        /// </summary>
        public DateTime FechadeSalida { get; set; }
        /// <summary>
        /// Fecha y Hora Limite
        /// </summary>
        public DateTime FechaLimite { get; set; }
        /// <summary>
        /// Fecha y Hora de Entrega
        /// </summary>
        public DateTime FechadeEntrega{ get; set; }
        /// <summary>
        /// Detalles del Libro
        /// </summary>
        public string DetallesdelLibro { get; set; }

        /// <summary>
        /// Llave foranea de Alumno
        /// </summary>
        public int IdAlumno { get; set; }
        public Alumno Alumno { get; set; }
        /// <summary>
        /// Llave Foranea Del Libro
        /// </summary>
        public int IdLibro { get; set; }
        public Libro Libro { get; set; }

    }
}