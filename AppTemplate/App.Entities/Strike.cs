using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace App.Entities
{
    public class Strikes
    {
        [Key]
        public int Id { get; set; }
        public string Motivo { get; set; }

        /// <summary>
        /// Llave foranea de Alumno
        /// </summary>
        public int IdAlumno { get; set; }
        public Alumno Alumno { get; set; }

        /// <summary>
        /// Llave foranea de Usuario
        /// </summary>
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

    }
}
