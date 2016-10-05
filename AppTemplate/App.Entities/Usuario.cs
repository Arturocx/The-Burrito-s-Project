using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace App.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            this.Strikes = new HashSet<Strikes>();
        }

        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Username { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }

        /// <summary>
        /// Relación a Strikes
        /// </summary>
        public virtual ICollection<Strikes> Strikes { get; set; }
    }
}
