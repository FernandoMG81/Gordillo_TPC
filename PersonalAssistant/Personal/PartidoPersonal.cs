using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Personal
{
    public class PartidoPersonal
    {
        private Int64 ID;

        public IList<Partido> listar(Int64 Id=0)
        {
            ID = Id;
            Conexion conexion = null;
            List<Partido> lista;
            Partido aux;

            try
            {
                conexion = new Conexion();
                lista = new List<Partido>();

                if (ID == 0)
                { 
                    conexion.setearConsulta("select IDpartido, partido from partido");
                }
                else
                {
                    conexion.setearConsulta("select IDpartido, partido from partido where IDpartido = "+ID.ToString());
                }
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while(conexion.Lector.Read())
                {
                    aux = new Partido();
                    aux.IDpartido = (Int64)conexion.Lector["IDpartido"];
                    aux.Nombre = (string)conexion.Lector["partido"];
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
                {
                    conexion.cerrarConexion();
                }
            }

            return lista;
        }
    }
}
