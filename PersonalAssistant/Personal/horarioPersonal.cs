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
                nuevo = new Empleado();
                conexion.setearConsulta("select r.nombre,r.apellido,r.dni from vw_registro_horario_entrada r inner join vw_registro_horario_salida s on r.dni = s.dni where s.salida is not null");
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                while(conexion.Lector.Read())
                {
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

        public List<Horario> listarSalida()
        {
            Conexion conexion = null;
            List<Horario> lista = new List<Horario>();
            Horario nuevo;
            try
            {
                conexion = new Conexion();
                nuevo = new Horario(); //p.IDregistroHorario,p.dni,e.nombre,e.apellido,p.inicio,p.salida,p.IDusuarioIngreso,p.IDusuarioSalida 
                conexion.setearConsulta("select IDregistroHorario, dni, nombre, apellido,inicio,salida  from vw_registro_horario_salida where salida is null");
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                while (conexion.Lector.Read())
                {
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
