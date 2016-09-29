﻿using System;
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
        public int NoControl { get; set; }
        public string Grupo { get; set; }
        public string Nombre { get; set; }
        public byte[] Photo { get; set; }
        public bool Bloqueado { get; set; }

    }
}
