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
        public int ID { get; set; }
        public int IDAlumno { get; set; }
        public int IDUsuario { get; set; }
        public string Motivo { get; set; }
    }
}
