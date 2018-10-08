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
                //conexion.ConnectionString = "data source =.;initial catalog = Gordillo_TPC; integrated security = sspi";
                conexion.ConnectionString = @"data source =.\SQLEXPRESS;initial catalog = Gordillo_TPC; integrated security = sspi"; //Data Source=DESKTOP-H1CONUT\\SQLEXPRESS;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select u.nombre,u.clave,u.sexo,tp.descripcion from usuarios u inner join tipoUsuario tp on u.Idtipo = tp.Idtipo";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Usuario();
                    aux.Nombre = (string)lector["nombre"];
                    aux.Password = (string)lector["clave"];
                    aux.Sexo = (string)lector["sexo"];
                    aux.Tipo = (string)lector["descripcion"];
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
