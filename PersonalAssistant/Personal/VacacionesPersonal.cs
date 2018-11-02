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
                vac = new Vacaciones();

                conexion.setearConsulta("select fecAlta, dni from empleado");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    vac.dni = (string)conexion.Lector["dni"];
                    vac.fecAlta = (DateTime)conexion.Lector["fecAlta"];
                    vac.DiasCalculado = vac.calcularVacaciones(vac.fecAlta, DateTime.Now);
                    vac.AnioCalculado = DateTime.Now.Year;

                    lista.Add(vac);
                }
                conexion.cerrarConexion();

                    conexion.setearConsulta("insert into vacacionesXempleado (dni,dias,anio) values(@dni,@dias,@anio)");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@dni", vac.dni);
                    conexion.Comando.Parameters.AddWithValue("@dias", vac.DiasCalculado);
                    conexion.Comando.Parameters.AddWithValue("@anio", vac.AnioCalculado);
                    conexion.abrirConexion();
                    conexion.ejecutarAccion();
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
