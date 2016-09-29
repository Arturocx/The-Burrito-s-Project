﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Libros
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Disponible { get; set; }
        public string Materia { get; set; }
        public string Detalles { get; set; }


    }
}