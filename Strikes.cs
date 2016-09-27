using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Strikes
    {
        public int ID { get; set; }
        public int IDAlumno { get; set; }
        public int IDUsuario { get; set; }
        public string Motivo { get; set; }
    }
}
