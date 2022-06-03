﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Models
{
    internal class TipoVehiculo
    {
        public int? Id { get; set; }
        [Required]

        public string Descripcion { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
