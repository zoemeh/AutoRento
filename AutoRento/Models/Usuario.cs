using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Models
{
    public class Usuario
    {
        public int? Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string password { get; set; }
        public override string ToString()
        {
            return nombre;
        }
    }
}
