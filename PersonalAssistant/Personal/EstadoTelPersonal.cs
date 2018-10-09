using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class EstadoTelPersonal
    {

        public IList<EstadoTelefono> listar ()
        {
            Conexion conexion = null;
            EstadoTelefono aux;
            List<EstadoTelefono> lista;
            try
            {
                lista = new List<EstadoTelefono>();
                conexion = new Conexion();
                conexion.setearConsulta("select ID, descripcion from estado_telefono");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new EstadoTelefono();
                    aux.Id = (byte)conexion.Lector["ID"];
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
