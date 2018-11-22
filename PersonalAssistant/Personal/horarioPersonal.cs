using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Personal
{
    public class horarioPersonal
    {
        public List<Empleado> listarIngreso ()
        {
            Conexion conexion = null;
            List<Empleado> lista = new List<Empleado>();
            Empleado nuevo;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("select r.nombre,r.apellido,r.dni from vw_registro_horario_entrada r where r.dni not in (select s.dni from vw_registro_horario_salida s where salida is null and r.dni = s.dni)");
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                while(conexion.Lector.Read())
                {
                    nuevo = new Empleado();
                    nuevo.Dni = (string)conexion.Lector["dni"];
                    nuevo.Nombre = (string)conexion.Lector["nombre"];
                    nuevo.Apellido = (string)conexion.Lector["apellido"];

                    lista.Add(nuevo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(conexion!=null)
                {
                    conexion.cerrarConexion();
                }
            }

            return lista;
        }

        public List<Horario> listarInforme(DateTime desde, DateTime hasta)
        {
            List<Horario> informe;
            Conexion conexion=null;
            Horario aux;
            try
            {
                conexion = new Conexion();
                informe = new List<Horario>();
                conexion.setearConsulta("select p.dni,p.inicio,p.salida,p.estado,p.IDusuarioIngreso,p.IDUsuarioSalida,e.nombre,e.apellido from planillaHoraria p, empleado e where inicio between @desde and @hasta and p.dni = e.dni");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@desde", desde);
                conexion.Comando.Parameters.AddWithValue("@hasta", hasta);
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Horario();
                    aux.dni = (string)conexion.Lector["dni"];
                    aux.Apellido = (string)conexion.Lector["apellido"];
                    aux.Nombre = (string)conexion.Lector["nombre"];
                    aux.Inicio = (DateTime)conexion.Lector["inicio"];
                    aux.Salida = (DateTime)conexion.Lector["salida"];
                    if ((bool)conexion.Lector["estado"]) aux.estado = "P";
                    else aux.estado = "A";

                    informe.Add(aux);
                }

                return informe;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion!=null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public List<Horario> listarSalida()
        {
            Conexion conexion = null;
            List<Horario> lista = new List<Horario>();
            Horario nuevo;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("select IDregistroHorario, dni, nombre, apellido,inicio,salida  from vw_registro_horario_salida where salida is null");
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                while (conexion.Lector.Read())
                {
                    nuevo = new Horario(); //p.IDregistroHorario,p.dni,e.nombre,e.apellido,p.inicio,p.salida,p.IDusuarioIngreso,p.IDusuarioSalida 
                    nuevo.dni = (string)conexion.Lector["dni"];
                    nuevo.Nombre = (string)conexion.Lector["nombre"];
                    nuevo.Apellido = (string)conexion.Lector["apellido"];
                    nuevo.IDregistro = (long)conexion.Lector["IDregistroHorario"];
                    nuevo.Inicio = (DateTime)conexion.Lector["inicio"];
                    
                    lista.Add(nuevo);
                }
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

            return lista;
        }
    }
}
