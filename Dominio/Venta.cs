using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    internal class Venta
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal TotalVenta { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; }

        public Venta()
        {
            DetallesVenta = new List<DetalleVenta>();
        }

    }
}
