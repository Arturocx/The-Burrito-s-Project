using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace App.Entities
{
    public class Computadora
    {
        public Computadora()
        {
            this.RegistroComputadora = new HashSet<RegistroComputadora>();
        }

        [Key]
        public int Id { get; set; }
        public int NoCubiculo { get; set; }
        public string ModeloCompu { get; set; }
        public string Status { get; set; }

        /// <summary>
        /// Relación a RegistroComputadora
        /// </summary>
        public virtual ICollection<RegistroComputadora> RegistroComputadora  { get; set; }

        
       
    }
}
