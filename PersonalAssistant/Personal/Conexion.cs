using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class Conexion
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public SqlCommand Comando
        {
            get { return comando; }
        }

        public Conexion()
        {
            conexion = new SqlConnection();
            //conexion.ConnectionString = "initial catalog = Gordillo_TPC; data source =.; integrated security = sspi";
            conexion.ConnectionString = "initial catalog = Gordillo_TPC; data source =TRCFAC05\\SQLEXPRESS; integrated security = sspi";
            //conexion.ConnectionString = @"data source =.\SQLEXPRESS;initial catalog = Gordillo_TPC ; integrated security = sspi";
        }

        public void setearConsulta(string consulta)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void setearSP (string SP)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = SP;
        }

        public void abrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            try
            {
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
