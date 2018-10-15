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
        public IList<Categoria> listar()
        {
            Conexion conexion = null;
            Categoria aux;
            List<Categoria> lista;
            try
            {
                lista = new List<Categoria>();
                conexion = new Conexion();
                conexion.setearConsulta("select IDcategoria, categoria, Idconcepto from categoria ");
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
    }
}
