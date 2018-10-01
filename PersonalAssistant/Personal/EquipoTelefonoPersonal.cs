using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class EquipoTelefonoPersonal
    {

        public IList<EquipoTelefono> Listar()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            IList<EquipoTelefono> lista = new List<EquipoTelefono>();
            EquipoTelefono aux;

            try
            {
                conexion.ConnectionString = "initial catalog = Gordillo_TPC; data source =TRCFAC05\\SQLEXPRESS; integrated security = sspi"; //Data Source=DESKTOP-H1CONUT\\SQLEXPRESS; TRCFAC05\\SQLEXPRESS
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select IMEI,modelo,marca,comentario, disponible from equipoTelefono";//case when disponible = 'true' then 'SI' when disponible = 'false' then 'NO'end as 'Disponible'
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new EquipoTelefono();
                    aux.Imei = lector.GetString(0);
                    aux.Modelo = lector.GetString(1);
                    aux.Marca = lector.GetString(2);
                    aux.Comentario = lector.GetString(3);
                    aux.Disponible = lector.GetBoolean(4);
                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;

            }

            finally
            {
                conexion.Close();
            }

        }

        public void alta (EquipoTelefono nuevo)
        {
            Conexion conexion = null;
            string consulta = "";

            try
            {
                conexion = new Conexion();
                consulta = "insert into EquipoTelefono (IMEI,Modelo,Marca,Disponible,Comentario)";
                consulta = consulta + " values ('" + nuevo.Imei + "','"+ nuevo.Modelo+ "','"+nuevo.Marca+ "','"+nuevo.Disponible.ToString()+"','"+nuevo.Comentario+ "')";

                conexion.setearConsulta(consulta);

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
                    conexion.cerrarConexion();
            }
        }

       
        
    }
}
