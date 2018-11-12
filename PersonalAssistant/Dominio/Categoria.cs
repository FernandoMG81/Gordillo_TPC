using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public Int64 Idcategoria { get; set; }
        public string nombre { get; set; }
        public Int64 IdConcepto { get; set; }

        public override string ToString()
        {
            return nombre;
        }

        
    }
}
