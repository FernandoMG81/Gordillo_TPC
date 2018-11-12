using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class ConceptoPersonal
    {
        public IList<Concepto> listar(long ID=0)
        {
            Conexion conexion = null;
            Concepto aux;
            List<Concepto> lista;
            try
            {
                lista = new List<Concepto>();
                conexion = new Conexion();
                if  (ID==0) conexion.setearConsulta("select IDconcepto,concepto,IDarea from concepto");
                else conexion.setearConsulta("select IDconcepto,concepto,IDarea from concepto where Idarea = "+ID.ToString());
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Concepto();
                    aux.IdConcepto= (Int64)conexion.Lector["IDConcepto"];
                    aux.Nombre = conexion.Lector.GetString(1);  //  (string)conexion.Lector["concepto"];
                    aux.IdArea = (Int64)conexion.Lector["Idarea"];
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

        public void alta(Concepto nuevo)
        {
            Conexion conexion = null;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("insert into concepto values (@concepto,@IdSeccion)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@concepto", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@IdSeccion", nuevo.IdArea);
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

        public void eliminar(Concepto baja)
        {
            Conexion conexion = null;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("delete from concepto where idconcepto = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", baja.IdConcepto);
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
