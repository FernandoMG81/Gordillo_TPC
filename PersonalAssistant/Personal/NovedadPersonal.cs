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
                conexion.setearConsulta("select convert(varchar,fechaNac,3)+'  '+ apellido +' '+nombre as emp from empleado where DATEPART(MONTH,fechaNac) = DATEPART(MONTH,GETDATE()) and baja = 0");
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
    }
}
