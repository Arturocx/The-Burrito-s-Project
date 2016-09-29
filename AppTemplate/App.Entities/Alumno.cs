using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }
        public int NoControl { get; set; }
        public string Grupo { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public bool Bloqueado { get; set; }

        /// <summary>
        /// Relación con RegistroComputadora
        /// </summary>
        public virtual ICollection<RegistroComputadora> RegistroComputadora { get; set; }


    }
}
