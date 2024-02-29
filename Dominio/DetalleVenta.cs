using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalleVenta
    {
        public int ID { get; set; }
        public int IDVenta { get; set; }
        public int IDMedicamento { get; set; }
        public int CantidadVendida { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
