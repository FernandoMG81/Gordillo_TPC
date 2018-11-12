using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public Int64 IDregistro { get; set; }
        public Contrato Contrato { get; set; }
        public Int64 Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Baja { get; set; }
        public DateTime BajaFecha { get; set; }
        public string BajaMotivo { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public char Sexo { get; set; }
        public string TelefonoPrincipal { get; set; }
        public string TelefonoSecundario { get; set; }
        public string Dni { get; set; }
        public string Cuil { get; set; }
        public string Entrecalle1 { get; set; }
        public string Entrecalle2 { get; set; }
        public int Hijos { get; set; }
        public string ObraSocial { get; set; }
        public DateTime VencimientoPrueba { get; set; }
        public Localidad Localidad { get; set; }
        public Categoria Categoria { get; set; }
        public Seccion Seccion { get; set; }
        public Concepto Concepto { get; set; }
        public Convenio Convenio { get; set; }
        public decimal Basico { get; set; }
        public bool TelefonoAsignado { get; set; }
        public bool ControlHorario { get; set; }
        public Usuario UsuarioCreacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Foto { get; set; }
    }
}
