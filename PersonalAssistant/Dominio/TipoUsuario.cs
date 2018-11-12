using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoUsuario
    {
        public const int ADMINISTRADOR = 1;
        public const int EMPLEADOS = 2;
        public const int HORARIO = 3;

        public byte Id { get; set; }
        public string Descripcion { get; set; }
    }
}
