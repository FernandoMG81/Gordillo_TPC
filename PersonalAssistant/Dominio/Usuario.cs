using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public long ID { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Sexo { get; set; }
        public string Tipo { get; set; }
    }
}
