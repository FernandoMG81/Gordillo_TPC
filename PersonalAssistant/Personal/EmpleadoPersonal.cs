using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class EmpleadoPersonal
    {







        public void alta(Empleado nuevo)
        {
            Conexion conexion = null;
            string consulta = "";
            try
            {
                conexion = new Conexion();
                consulta = "insert into empleado (fecAlta,IDcontrato,IDseccion,IDconcepto,IDconvenio,IDcategoria,nombre,apellido,fechaNac,dni,cuil,nacionalidad,IDestadoCivil,hijos,Domicilio,entrecalle1,entrecalle2,cp)";
                consulta = consulta + "values (@fecAlta,@IDcontrato,@IDseccion,@IDconcepto,@IDconvenio,@IDcategoria,@nombre,@apellido,@fechaNac,@dni,@cuil,@nacionalidad,@IDestadoCivil,@hijos,@Domicilio,@entrecalle1,@entrecalle2,@cp)";
                conexion.setearConsulta(consulta);
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@fecAlta",nuevo.FechaAlta);
                conexion.Comando.Parameters.AddWithValue("@IDcontrato", nuevo.IDContrato);
                conexion.Comando.Parameters.AddWithValue("@IDseccion", nuevo.IDSeccion);
                conexion.Comando.Parameters.AddWithValue("@IDconcepto", nuevo.IDConcepto);
                conexion.Comando.Parameters.AddWithValue("@IDconvenio", nuevo.IDConvenio);
                conexion.Comando.Parameters.AddWithValue("@IDcategoria", nuevo.IDCategoria);
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@fechaNac", nuevo.FechaDeNacimiento);
                conexion.Comando.Parameters.AddWithValue("@dni", nuevo.Dni);
                conexion.Comando.Parameters.AddWithValue("@cuil", nuevo.Cuil);
                conexion.Comando.Parameters.AddWithValue("@nacionalidad", nuevo.Nacionalidad);
                conexion.Comando.Parameters.AddWithValue("@IDestadoCivil", nuevo.EstadoCivil);
                conexion.Comando.Parameters.AddWithValue("@hijos", nuevo.Hijos);
                conexion.Comando.Parameters.AddWithValue("@Domicilio", nuevo.Domicilio);
                conexion.Comando.Parameters.AddWithValue("@entrecalle1", nuevo.Entrecalle1);
                conexion.Comando.Parameters.AddWithValue("@entrecalle2", nuevo.Entrecalle2);
                conexion.Comando.Parameters.AddWithValue("@cp", nuevo.CP);



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
