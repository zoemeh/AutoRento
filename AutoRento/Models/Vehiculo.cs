using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Models
{
    internal class Vehiculo
    {
        public int? Id { get; set; }
        public string Descripcion { get; set; }
        public string NumeroChasis { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroPlaca { get; set; }
        public int TipoVehiculoId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int TipoCombustibleId { get; set; }
        public bool Estado { get; set; }
    }
}
