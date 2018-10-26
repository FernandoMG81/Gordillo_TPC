using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Personal
{
    public class equipoXusuarioPersonal
    {
        public List<equipoXusuario> listarAsignados()
        {
            Conexion conexion = null;
            equipoXusuario aux;
            List<equipoXusuario> lista = new List<equipoXusuario>();
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("select te.IDregistro, apellido, nombre, empleado.dni,comentario, e.IMEI, modelo, te.fecAlta, te.fecBaja from empleado inner join Tel_x_empleado te on empleado.dni = te.Dni inner join equipoTelefono e on te.Imei = e.IMEI where te.fecBaja is null");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new equipoXusuario();
                    aux.IDregistro = (long)conexion.Lector["IDregistro"];
                    aux.IMEI = (string)conexion.Lector["IMEI"];
                    aux.DNI = (string)conexion.Lector["dni"];
                    aux.Nempleado = (string)conexion.Lector["nombre"];
                    aux.Aempleado = (string)conexion.Lector["apellido"];
                    aux.Modelo = (string)conexion.Lector["modelo"];
                    aux.fechaAlta = (DateTime)conexion.Lector["fecAlta"];
                    aux.Comentario = (string)conexion.Lector["comentario"];
                    if (!conexion.Lector.IsDBNull(8))
                    {
                        aux.fechaBaja = (DateTime)conexion.Lector["fecBaja"];

                    }
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
