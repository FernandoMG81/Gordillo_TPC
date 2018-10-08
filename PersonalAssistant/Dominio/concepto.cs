using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Concepto
    {
        public Int64 IdConcepto { get; set; }
        public string Nombre { get; set; }
        public Int64 IdArea { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
