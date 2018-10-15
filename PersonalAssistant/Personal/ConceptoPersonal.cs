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
        public IList<Concepto> listar()
        {
            Conexion conexion = null;
            Concepto aux;
            List<Concepto> lista;
            try
            {
                lista = new List<Concepto>();
                conexion = new Conexion();
                conexion.setearConsulta("select IDconcepto,concepto,IDarea from concepto");
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
    }
}
