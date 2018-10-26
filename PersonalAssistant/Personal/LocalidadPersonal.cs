using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Personal
{
    public class LocalidadPersonal
    {
        private Int64 cp;

        public List<Localidad> listar(Int64 CP = 0)
        {
            cp = CP;
            Conexion conexion = null;
            List<Localidad> lista = new List<Localidad>();
            Localidad aux;
            try
            {
                conexion = new Conexion();
                if (cp == 0)
                {
                    conexion.setearConsulta("Select IDlocalidad, localidad,cp, IDpartido, partido from vw_listado_localidad");
                }
                else
                {
                    conexion.setearConsulta("Select IDlocalidad, localidad,cp, IDpartido, partido from vw_listado_localidad where cp = " + cp.ToString());
                }
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Localidad();
                    aux.IDlocalidad = (Int64)conexion.Lector["IDlocalidad"];
                    aux.Nombre = (string)conexion.Lector["localidad"];
                    aux.cp = (Int64)conexion.Lector["cp"];
                    aux.IDpartido = (Int64)conexion.Lector["IDpartido"];
                    lista.Add(aux);
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

        public Localidad buscarIDpartido(Int64 codigo)
        {
            Conexion conexion = null;
            Localidad aux;
            try
            {
                aux = new Localidad();
                conexion = new Conexion();
                conexion.setearConsulta("select cp,IDlocalidad,IDpartido,localidad from localidad where IDlocalidad like '" + codigo.ToString() + "'");
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                conexion.Lector.Read();
                aux.cp = (Int64)conexion.Lector["CP"];
                aux.IDlocalidad = (Int64)conexion.Lector["IDlocalidad"];
                aux.IDpartido = (Int64)conexion.Lector["IDpartido"];
                aux.Nombre = (string)conexion.Lector["localidad"];



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
            return aux;
        }
    }
}
