using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class ContratoPersonal
    {
        public IList<Contrato> listar()
        {
            Conexion conexion = null;
            Contrato aux;
            List<Contrato> lista;
            try
            {
                lista = new List<Contrato>();
                conexion = new Conexion();
                conexion.setearConsulta("select IDcontrato,contrato from contrato");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Contrato();
                    aux.Idcontrato = (Int64)conexion.Lector["IDcontrato"];
                    aux.Descripcion = (string)conexion.Lector["contrato"];
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
