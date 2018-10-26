using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class equipoXusuario
    {
        public long IDregistro { get; set; }
        public string IMEI { get; set; }
        public string DNI { get; set; }
        public string Nempleado { get; set; }
        public string Aempleado { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaBaja { get; set; }
        public string Modelo { get; set; }
        public string Comentario { get; set; }
    }
}
