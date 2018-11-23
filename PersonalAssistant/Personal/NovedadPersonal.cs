using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Personal;

namespace Personal
{
    public class NovedadPersonal
    {
        public List<Novedad> traerCumpleaniosMes()
        {
            List<Novedad> lista;
            Conexion conexion;
            Novedad aux;
            try
            {
                conexion = new Conexion();
                lista = new List<Novedad>();
                conexion.setearConsulta("select convert(varchar,fechaNac,3)+'  '+ apellido +' '+nombre as emp from empleado where DATEPART(MONTH,fechaNac) = DATEPART(MONTH,GETDATE()) and baja = 0 order by datepart(day,fechaNac) asc");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    
                aux = new Novedad();
                    aux.NovedadPrincipal = (string)conexion.Lector["emp"];
                lista.Add(aux);
                }
     

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Novedad> traerCumpleaniosDia()
        {
            List<Novedad> lista;
            Conexion conexion;
            Novedad aux;
            try
            {
                conexion = new Conexion();
                lista = new List<Novedad>();
                
                conexion.cerrarConexion();
                conexion.setearConsulta("select convert(varchar,fechaNac,3)+'  '+ apellido +' '+nombre as emp from empleado where DATEPART(MONTH,fechaNac) = DATEPART(MONTH,GETDATE()) and DATEPART(DAY,fechaNac) = DATEPART(DAY,GETDATE()) and baja = 0");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {

                    aux = new Novedad();
                    aux.NovedadPrincipal = (string)conexion.Lector["emp"];
                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Novedad> traerVencimientos()
        {
            List<Novedad> lista;
            Conexion conexion;
            Novedad aux;
            try
            {
                conexion = new Conexion();
                lista = new List<Novedad>();

                conexion.cerrarConexion();
                conexion.setearConsulta("select (e.apellido + ' ' + e.nombre + ' - '+ SUBSTRING(s.seccion,1,3) + ' - '+ CONVERT(varchar(20),e.vencimiento,103)) as emp from empleado e,seccion s where e.IDseccion = s.IDseccion and e.vencimiento is not null and e.vencimiento >= GETDATE() order by e.vencimiento asc");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {

                    aux = new Novedad();
                    aux.NovedadPrincipal = (string)conexion.Lector["emp"];
                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Novedad> traerVacaciones()
        {
            List<Novedad> lista;
            Conexion conexion;
            Novedad aux;
            try
            {
                conexion = new Conexion();
                lista = new List<Novedad>();

                conexion.cerrarConexion();
                conexion.setearConsulta("select (e.apellido + ' ' + e.nombre + ' - '+ SUBSTRING(s.seccion,1,3) + ' - '+ CONVERT(varchar(20),v.fIni,103)) as emp from vacaciones v, empleado e,seccion s where e.IDseccion = s.IDseccion and e.dni = v.dni and v.fIni between getdate() and GETDATE()+DAY(15) order by v.fIni asc");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {

                    aux = new Novedad();
                    aux.NovedadPrincipal = (string)conexion.Lector["emp"];
                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
