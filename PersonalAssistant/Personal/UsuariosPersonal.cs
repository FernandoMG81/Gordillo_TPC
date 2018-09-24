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
        public IList<Usuarios> Listar()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            IList<Usuarios> lista = new List<Usuarios>();
            Usuarios aux;

            try
            {
                conexion.ConnectionString = "initial catalog = Gordillo_TPC; data source =.; integrated security = sspi"; //Data Source=DESKTOP-H1CONUT\\SQLEXPRESS; TRCFAC05\\SQLEXPRESS
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select u.nombre,u.clave,tp.decripcion from usuarios u inner join tipoUsuario tp on u.Idtipo = tp.Idtipo";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Usuarios();
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

    }
}
