using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class SeccionPersonal
    {
        public IList<Seccion> listar(long id=0)
        {
            Conexion conexion = null;
            Seccion aux;
            List<Seccion> lista;
            try
            {
                lista = new List<Seccion>();
                conexion = new Conexion();
                if (id==0) conexion.setearConsulta("select IDseccion, seccion from seccion");
                else conexion.setearConsulta("select IDseccion, seccion from seccion where idSeccion = "+id.ToString());
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Seccion();
                    aux.Idseccion = (Int64)conexion.Lector["IDseccion"];
                    aux.Nombre = (string)conexion.Lector["seccion"];
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
                    conexion.cerrarConexion();
            }

            return lista;
        }

        public void alta(Seccion nuevo)
        {
            Conexion conexion = null;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("insert into seccion values (@seccion)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@seccion", nuevo.Nombre);
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

        public void eliminar(Seccion baja)
        {
            Conexion conexion = null;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("delete from seccion where idseccion = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", baja.Idseccion);
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
    }
}
