using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Medicamento
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public double  precioUnitario{ get; set; }
        public int cantidadStock { get; set; }

    }
}
