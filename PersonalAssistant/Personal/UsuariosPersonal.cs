using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class UsuariosPersonal
    {
        public IList<Usuario> Listar()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            IList<Usuario> lista = new List<Usuario>();
            Usuario aux;

            try
            {
                conexion.ConnectionString = "initial catalog = Gordillo_TPC; data source =TRCFAC05\\SQLEXPRESS; integrated security = sspi"; //Data Source=DESKTOP-H1CONUT\\SQLEXPRESS; TRCFAC05\\SQLEXPRESS
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select u.nombre,u.clave,tp.decripcion from usuarios u inner join tipoUsuario tp on u.Idtipo = tp.Idtipo";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Usuario();
                    aux.Nombre = lector.GetString(0);
                    aux.Password = lector.GetString(1);
                    aux.Tipo = lector.GetString(2);
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

        public void alta(Usuario nuevo)
        {
            Conexion conexion = null;
            string consulta = "";
            try
            {
                conexion = new Conexion();
                consulta = "insert into usuarios (nombre, clave, Idtipo)";
                consulta = consulta + " VALUES ('" + nuevo.Nombre + "','" + nuevo.Password + "'," + nuevo.Tipo + ")";

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

        public void baja(Usuario baja)
        {
            Conexion conexion = null;
            string consulta = "";

            try
            {
                conexion = new Conexion();
                consulta = "delete from usuarios where usuarios.nombre =";
                consulta = consulta + "'" + baja.Nombre + "'";

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
                {
                    conexion.cerrarConexion();
                }
            }
        }

    }
}
