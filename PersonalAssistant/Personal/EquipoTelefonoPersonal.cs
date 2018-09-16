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
                conexion.ConnectionString = "initial catalog = Gordillo_TPC; data source =DESKTOP-H1CONUT\\SQLEXPRESS; integrated security = sspi"; //Data Source=DESKTOP-H1CONUT\SQLEXPRESS;Initial Catalog=Gordillo_TPC;Integrated Security=True
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select IMEI,modelo,marca,comentario, case when disponible = 1 then 'SI' when disponible = 0 then 'NO'end as 'Disponible'from equipoTelefono";
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
                    aux.Disponible = lector.GetString(4);
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
