using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int MyProperty { get; set; }
        public Direccion Direccion { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Baja { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string EstadoCivil { get; set; }
        public char Sexo { get; set; }
        public List<Telefono> Telefonos { get; set; }
        public int Dni { get; set; }
        public string Cuil { get; set; }
        public string Convenio { get; set; }
        public int Hijos { get; set; }
        public string ObraSocial { get; set; }
        public string TipoContrato { get; set; }
        public DateTime VencimientoPrueba { get; set; }
        public TipoEmpleado Puesto { get; set; }
        public string Categoria { get; set; }
        public string Area { get; set; }
        public int Basico { get; set; }
    }
}
