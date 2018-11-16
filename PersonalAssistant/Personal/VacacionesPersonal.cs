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
        public void generar(int year,Usuario user)
        {
            Conexion conexion = null;
            Vacaciones vac;
            Empleado emp;
            List<Vacaciones> lista = new List<Vacaciones>();
            try
            {
                emp = new Empleado();
                conexion = new Conexion();

                conexion.setearConsulta("select fecAlta, dni from empleado where baja = 'false' and dni not in (select dni from vacacionesXempleado where anio = "+ year +")");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    vac = new Vacaciones();
                    vac.dni = (string)conexion.Lector["dni"];
                    vac.fecAlta = (DateTime)conexion.Lector["fecAlta"];
                    vac.DiasCalculado = vac.calcularVacaciones(vac.fecAlta,year);
                    vac.AnioCalculado = year;

                    lista.Add(vac);
                }

                if (lista.Count == 0) throw new SystemException();
                foreach (var persona in lista)
                {
                    conexion.cerrarConexion();
                    conexion.setearConsulta("insert into vacacionesXempleado (dni,diasRestantes,diasAsignados,anio,idusuario,fcreacion) values(@dni,@dias,@dias,@anio,@idusuario,@fcreacion)");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@dni", persona.dni);
                    conexion.Comando.Parameters.AddWithValue("@dias", persona.DiasCalculado);
                    conexion.Comando.Parameters.AddWithValue("@anio", persona.AnioCalculado);
                    conexion.Comando.Parameters.AddWithValue("@idUsuario", user.ID);
                    conexion.Comando.Parameters.AddWithValue("@fCreacion", DateTime.Now);
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

        public object listarVacacionesAsignadas(object anio)
        {
            Conexion conexion = null;
            Vacaciones vac;
            List<Vacaciones> lista = new List<Vacaciones>();
            try
            {
                conexion = new Conexion();

                conexion.setearConsulta("select v.dni,v.dias,v.fIni,v.fFin,v.anio,us.nombre as usuario,v.fcreacion, e.nombre,e.apellido from vacaciones v,usuarios us,empleado e where anio = @anio and v.dni = e.dni and us.idregistro = v.idusuario");
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
                    vac.FechaInicio = (DateTime)conexion.Lector["fIni"];
                    vac.FechaFinal = (DateTime)conexion.Lector["fFin"];
                    vac.UsuarioCreacion = new Usuario();
                    vac.UsuarioCreacion.Nombre = (string)conexion.Lector["usuario"];
                    vac.FechaCreacion = (DateTime)conexion.Lector["fCreacion"];

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

        public string traerDiasDisponibles(string dni, string anio)
        {
            string dias="";
            Conexion conexion = null;
            
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("select top 1 diasRestantes from vacacionesXempleado where anio = @anio and dni = @dni");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@anio",anio);
                conexion.Comando.Parameters.AddWithValue("@dni",dni);
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                conexion.Lector.Read();
                dias = Convert.ToString(conexion.Lector["diasRestantes"]);

                return dias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void nuevasVacaciones(Vacaciones nuevo, Usuario user)
        {
            Conexion conexion = null;

            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("insert into vacaciones(dni,dias,fIni,fFin,anio,idusuario,fcreacion) values (@dni,@dias,@fIni,@fFin,@anio,@idusuario,@fcreacion)");
                conexion.Comando.Parameters.AddWithValue("@dni", nuevo.dni);
                conexion.Comando.Parameters.AddWithValue("@dias", nuevo.DiasVacaciones);
                conexion.Comando.Parameters.AddWithValue("@fIni", nuevo.FechaInicio);
                conexion.Comando.Parameters.AddWithValue("@fFin", nuevo.FechaFinal);
                conexion.Comando.Parameters.AddWithValue("@anio", nuevo.AnioCalculado);
                conexion.Comando.Parameters.AddWithValue("@idUsuario", user.ID);
                conexion.Comando.Parameters.AddWithValue("@fCreacion", DateTime.Now);
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
                {
                    conexion.cerrarConexion();
                }
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

                conexion.setearConsulta("select e.nombre,e.apellido,v.dni from vacacionesXempleado v, empleado e where v.dni = e.dni and v.anio = "+anio+"and v.diasRestantes > 0");
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
            
                conexion.setearConsulta("select v.dni,v.diasRestantes,v.diasAsignados,v.anio,e.nombre,e.apellido, u.nombre as usuario,v.fCreacion from vacacionesXempleado v, empleado e, usuarios u where v.anio = @anio and v.dni = e.dni and v.IDusuario = u.Idregistro");
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
                    vac.DiasVacaciones = (int)conexion.Lector["diasRestantes"];
                    vac.DiasCalculado = (int)conexion.Lector["diasAsignados"];
                    vac.AnioCalculado = (int)conexion.Lector["anio"];
                    vac.UsuarioCreacion = new Usuario();
                    vac.UsuarioCreacion.Nombre = (string)conexion.Lector["usuario"];
                    vac.FechaCreacion = (DateTime)conexion.Lector["fcreacion"];
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
