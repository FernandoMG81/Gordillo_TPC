using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoEmpleado
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public bool Disponible { get; set; }
        public string Comentario { get; set; }
    }
}
