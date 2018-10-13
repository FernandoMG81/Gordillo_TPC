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
        public IList<Empleado> listar ()
        {
            List<Empleado> lista = new List<Empleado>();
            Empleado aux;
            Conexion conexion;
            try
            {
                aux = new Empleado();
                conexion = new Conexion();
                conexion.setearConsulta("select legajo,fecAlta,IDcontrato, IDseccion,IDconcepto,IDconvenio,IDcategoria,nombre," +
                    "apellido,fechaNac,dni,cuil,nacionalidad,IDestadoCivil,hijos,domicilio,entreCalle1,entreCalle2,cp from empleado");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while(conexion.Lector.Read())
                {
                    if (!conexion.Lector.IsDBNull(0))
                    {
                        aux.Legajo = (Int64)conexion.Lector["legajo"];
                        
                    }
                    aux.FechaAlta = (DateTime)conexion.Lector["fecAlta"];
                    aux.IDContrato = (Int64)conexion.Lector["IDcontrato"];
                    aux.IDSeccion = (Int64)conexion.Lector["IDseccion"];
                    aux.IDConcepto = (Int64)conexion.Lector["IDconcepto"];
                    aux.IDConvenio = (Int64)conexion.Lector["IDconvenio"];
                    aux.IDCategoria = (Int64)conexion.Lector["IDcategoria"];
                    aux.Nombre = (string)conexion.Lector["nombre"];
                    aux.Apellido = (string)conexion.Lector["apellido"];
                    aux.FechaDeNacimiento = (DateTime)conexion.Lector["fechaNac"];
                    aux.Dni = (string)conexion.Lector["dni"];
                    aux.Cuil = (string)conexion.Lector["cuil"];
                    aux.Nacionalidad = (string)conexion.Lector["nacionalidad"];
                    aux.EstadoCivil = (byte)conexion.Lector["IDestadoCivil"];
                    aux.Hijos = (int)conexion.Lector["hijos"];
                    aux.Domicilio = (string)conexion.Lector["domicilio"];
                    aux.Entrecalle1 = (string)conexion.Lector["entreCalle1"];
                    aux.Entrecalle2 = (string)conexion.Lector["entreCalle2"];
                    aux.CP = (Int64)conexion.Lector["CP"];
                    lista.Add(aux);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }






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
