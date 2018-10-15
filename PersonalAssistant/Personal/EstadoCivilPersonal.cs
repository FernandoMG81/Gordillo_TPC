using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class EstadoCivilPersonal
    {
        public IList<EstadoCivil> listar()
        {
            Conexion conexion = null;
            EstadoCivil aux;
            List<EstadoCivil> lista;
            try
            {
                lista = new List<EstadoCivil>();
                conexion = new Conexion();
                conexion.setearConsulta("select IDestadoCivil, estado from estadoCivil");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new EstadoCivil();
                    aux.IdEstadoCivil = (byte)conexion.Lector["IDestadoCivil"];
                    aux.Descripcion = (string)conexion.Lector["estado"];
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
