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
        [Key]
        public int Id { get; set; }
        public int NoCubiculo { get; set; }
        public string ModeloCompu { get; set; }
        public string Status { get; set; }

    }
}
