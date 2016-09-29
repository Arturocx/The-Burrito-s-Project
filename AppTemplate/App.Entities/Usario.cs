using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace App.Entities
{
    public class Usario
    {
        [Key]
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Username { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
    }
}
