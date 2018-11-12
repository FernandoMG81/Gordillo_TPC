using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class CategoriaPersonal
    {
        public IList<Categoria> listar(long Idcon = 0)
        {
            Conexion conexion = null;
            Categoria aux;
            List<Categoria> lista;
            try
            {
                lista = new List<Categoria>();
                conexion = new Conexion();
                if (Idcon==0) conexion.setearConsulta("select IDcategoria, categoria, Idconcepto from categoria ");
                else conexion.setearConsulta("select IDcategoria, categoria, Idconcepto from categoria where Idconcepto = " + Idcon.ToString());
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Categoria();
                    aux.Idcategoria = (Int64)conexion.Lector["IDcategoria"];
                    aux.nombre = (string)conexion.Lector["categoria"];
                    aux.IdConcepto = (Int64)conexion.Lector["Idconcepto"];
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

        public void alta(Categoria nuevo)
        {
            Conexion conexion = null;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("insert into categoria values (@categoria,@Idconcepto)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@categoria", nuevo.nombre);
                conexion.Comando.Parameters.AddWithValue("@Idconcepto", nuevo.IdConcepto);
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

        public void eliminar(Categoria baja)
        {
            Conexion conexion = null;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("delete from categoria where idcategoria = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", baja.Idcategoria);
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
