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
                //conexion.ConnectionString = "data source =.; initial catalog = Gordillo_TPC; ; integrated security = sspi";
                conexion.ConnectionString = @"data source =.\SQLEXPRESS; initial catalog = Gordillo_TPC; integrated security = sspi"; //; TRCFAC05\\SQLEXPRESS
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select e.IMEI, e.marca,e.modelo, e.disponible, t.descripcion as Estado from equipoTelefono e inner join estado_telefono t on e.Idestado = t.ID";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new EquipoTelefono();
                    aux.Imei = (string)lector["IMEI"];
                    aux.Modelo = (string)lector["modelo"];
                    aux.Marca = (string)lector["marca"];
                    aux.Condicion = (string)lector["estado"];
                    aux.Disponible = (bool)lector["disponible"];
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
                consulta = "insert into EquipoTelefono (IMEI,Modelo,Marca,Disponible,Idestado) values (@IMEI,@modelo,@marca,1,1)";
                conexion.setearConsulta(consulta);

                //consulta = consulta + " values ('" + nuevo.Imei + "','"+ nuevo.Modelo+ "','"+nuevo.Marca+ "','"+nuevo.Disponible.ToString()+"','"+nuevo.Comentario+ "')";
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IMEI", nuevo.Imei);
                conexion.Comando.Parameters.AddWithValue("@modelo", nuevo.Modelo);
                conexion.Comando.Parameters.AddWithValue("@marca", nuevo.Marca);
                //conexion.Comando.Parameters.AddWithValue("@estado", nuevo.Condicion);

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
