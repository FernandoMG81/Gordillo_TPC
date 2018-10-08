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
        public IList<Seccion> listar()
        {
            Conexion conexion = null;
            Seccion aux;
            List<Seccion> lista;
            try
            {
                lista = new List<Seccion>();
                conexion = new Conexion();
                conexion.setearConsulta("select IDseccion, descripcion from seccion");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Seccion();
                    aux.Idseccion = (Int64)conexion.Lector["IDseccion"];
                    aux.Nombre = (string)conexion.Lector["descripcion"];
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
    }
}
