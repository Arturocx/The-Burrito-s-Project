using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    public class Libro
    {
        public Libro()
        {
            this.RegistroLibro = new HashSet<Registro_de_Libro>();
        }
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Disponible { get; set; }
        public string Materia { get; set; }
        public string Detalles { get; set; }

        /// <summary>
        /// Relación a RegistrodeLibro
        /// </summary>
        public virtual ICollection<Registro_de_Libro> RegistroLibro { get; set; }
    }
}