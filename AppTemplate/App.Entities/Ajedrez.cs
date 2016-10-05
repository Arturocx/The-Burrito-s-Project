using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    public class Ajedrez
    {
        public Ajedrez()
        {
            this.RegistroAjedrez = new HashSet<RegistroAjedrez>();
        }

        /// <summary>
        /// Identificador de la tabla Registro Ajedrez
        /// </summary>
        [Key]
        public int Id { get; set; }
        public int NoMesa { get; set; }

        /// <summary>
        /// Relación con RegistroAjedrez
        /// </summary>
        public virtual ICollection<RegistroAjedrez> RegistroAjedrez { get; set; }

    }
}
