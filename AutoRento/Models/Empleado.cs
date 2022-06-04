using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Models
{
    public enum TandaLabor
    {
        Manana,
        Noche
    }
    public class Empleado
    {
        public int? Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public TandaLabor TandaLabor { get; set; }
        public double PorcienteComision { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

    }
}
