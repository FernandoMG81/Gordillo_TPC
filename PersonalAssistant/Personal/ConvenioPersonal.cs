using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class ConvenioPersonal
    {
        public IList<Convenio> listar()
        {
            Conexion conexion = null;
            Convenio aux;
            List<Convenio> lista;
            try
            {
                lista = new List<Convenio>();
                conexion = new Conexion();
                conexion.setearConsulta("select IDconvenio,convenio from convenio");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Convenio();
                    aux.IDconvenio = (Int64)conexion.Lector["IDconvenio"];
                    aux.Descripcion = (string)conexion.Lector["convenio"];
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

        public void alta(Convenio nuevo)
        {
            Conexion conexion = null;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("insert into convenio values (@convenio)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@convenio", nuevo.Descripcion);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
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

        public void eliminar(Convenio baja)
        {
            Conexion conexion = null;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("delete from convenio where idconvenio = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", baja.IDconvenio);
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
