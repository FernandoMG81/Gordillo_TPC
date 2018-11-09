using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Personal
{
    public class VacacionesPersonal
    {
        public void generar()
        {
            Conexion conexion = null;
            Vacaciones vac;
            Empleado emp;
            List<Vacaciones> lista = new List<Vacaciones>();
            try
            {
                emp = new Empleado();
                conexion = new Conexion();

                conexion.setearConsulta("select fecAlta, dni from empleado");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    vac = new Vacaciones();
                    vac.dni = (string)conexion.Lector["dni"];
                    vac.fecAlta = (DateTime)conexion.Lector["fecAlta"];
                    vac.DiasCalculado = vac.calcularVacaciones(vac.fecAlta, DateTime.Now.Year);
                    vac.AnioCalculado = DateTime.Now.Year;

                    lista.Add(vac);
                }

                foreach (var persona in lista)
                {
                    conexion.cerrarConexion();
                    conexion.setearConsulta("insert into vacacionesXempleado (dni,dias,anio) values(@dni,@dias,@anio)");
                    conexion.Comando.Parameters.AddWithValue("@dni", persona.dni);
                    conexion.Comando.Parameters.AddWithValue("@dias", persona.DiasCalculado);
                    conexion.Comando.Parameters.AddWithValue("@anio", persona.AnioCalculado);
                    conexion.abrirConexion();
                    conexion.ejecutarAccion();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }

        }

        public string traerDiasDisponibles(string dni, string anio)
        {
            string dias="";
            Conexion conexion = null;
            
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("select top 1 dias from vacacionesXempleado where anio = @anio and dni = @dni");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@anio",anio);
                conexion.Comando.Parameters.AddWithValue("@dni",dni);
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                conexion.Lector.Read();
                dias = Convert.ToString(conexion.Lector["dias"]);

                return dias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public object listarEmpleados(string anio)
        {
            Conexion conexion = null;
            Vacaciones vac;
            List<Vacaciones> lista = new List<Vacaciones>();
            try
            {
                conexion = new Conexion();

                conexion.setearConsulta("select v.dni,v.dias,v.anio,e.nombre,e.apellido from vacacionesXempleado v inner join empleado e on v.dni = e.dni where anio = @anio and v.dias > 0");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@anio", anio);
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    vac = new Vacaciones();
                    vac.dni = (string)conexion.Lector["dni"];
                    vac.Nombre = (string)conexion.Lector["nombre"];
                    vac.Apellido = (string)conexion.Lector["apellido"];
                    vac.DiasVacaciones = (int)conexion.Lector["dias"];
                    vac.AnioCalculado = (int)conexion.Lector["anio"];

                    lista.Add(vac);


                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }
        }

        public object listar(string anio)
        {
            Conexion conexion = null;
            Vacaciones vac;
            List<Vacaciones> lista = new List<Vacaciones>();
            try
            {
                conexion = new Conexion();
            
                conexion.setearConsulta("select v.dni,v.dias,v.anio,e.nombre,e.apellido from vacacionesXempleado v inner join empleado e on v.dni = e.dni where anio = @anio");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@anio", anio);
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    vac = new Vacaciones();
                    vac.dni = (string)conexion.Lector["dni"];
                    vac.Nombre = (string)conexion.Lector["nombre"];
                    vac.Apellido = (string)conexion.Lector["apellido"];
                    vac.DiasVacaciones = (int)conexion.Lector["dias"];
                    vac.AnioCalculado = (int)conexion.Lector["anio"];

                    lista.Add(vac);

                    
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }
        }
    }
}
