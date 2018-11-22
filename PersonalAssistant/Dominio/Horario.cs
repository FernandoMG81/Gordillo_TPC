using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Horario
    {
        public long IDregistro { get; set; }
        public string dni { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Salida { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string estado { get; set; }
    }
}
