using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public Int64 IDContrato { get; set; }
        public Int64 Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //public Direccion Direccion { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Baja { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public byte EstadoCivil { get; set; }
        public char Sexo { get; set; }
        public List<Telefono> Telefonos { get; set; }
        public string Dni { get; set; }
        public string Cuil { get; set; }
        public string Entrecalle1 { get; set; }
        public string Entrecalle2 { get; set; }
        public int Hijos { get; set; }
        public string ObraSocial { get; set; }
        public DateTime VencimientoPrueba { get; set; }
        public Int64 CP { get; set; }
        //public TipoEmpleado Puesto { get; set; }
        public Int64 IDCategoria { get; set; }
        public Int64 IDSeccion { get; set; }
        public Int64 IDConcepto { get; set; }
        public Int64 IDConvenio { get; set; }
        public int Basico { get; set; }
    }
}
