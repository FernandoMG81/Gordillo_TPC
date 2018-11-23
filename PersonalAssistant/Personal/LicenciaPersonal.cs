using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Personal
{
    public class LicenciaPersonal
    {
        public List<Licencia> listar()
        {
            Conexion conexion = null;
            List<Licencia> lista = new List<Licencia>();
            Licencia aux;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("select l.idregistro,l.dni,l.fechaInicio,l.fechaFinalizacion,l.motivo,l.idusuario,e.nombre,e.apellido,l.fechaCreacion,u.nombre as usuario from licencias l, empleado e, usuarios u where l.dni = e.dni and l.idusuario = u.idregistro");
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                while (conexion.Lector.Read())
                {
                    aux = new Licencia();
                    aux.DNI = (string)conexion.Lector["dni"];
                    aux.FechaCreacion = (DateTime)conexion.Lector["fechaCreacion"];
                    aux.FechaInicio = (DateTime)conexion.Lector["fechaInicio"];
                    aux.FechaFinal = (DateTime)conexion.Lector["fechaFinalizacion"];
                    aux.Idregistro = (long)conexion.Lector["idRegistro"];
                    aux.Nombre = (string)conexion.Lector["nombre"];
                    aux.Apellido = (string)conexion.Lector["apellido"];
                    aux.Usuario = new Usuario();
                    aux.Usuario.ID = (long)conexion.Lector["Idusuario"];
                    aux.Usuario.Nombre = (string)conexion.Lector["usuario"];

                    aux.Motivo = (string)conexion.Lector["motivo"];
                    
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

        public void agregar(Licencia nuevo)
        {
            Conexion conexion = null;
            
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("insert into licencias (dni,fechaInicio,fechaFinalizacion,motivo,idusuario,fechaCreacion) values (@dni,@fechaI,@fechaF,@Motivo,@idUsuario,@fechaCreacion)");
                conexion.Comando.Parameters.AddWithValue("@dni",nuevo.DNI);
                conexion.Comando.Parameters.AddWithValue("@fechaI",nuevo.FechaInicio);
                conexion.Comando.Parameters.AddWithValue("@fechaF",nuevo.FechaFinal);
                conexion.Comando.Parameters.AddWithValue("@Motivo",nuevo.Motivo);
                conexion.Comando.Parameters.AddWithValue("@idUsuario",nuevo.Usuario.ID);
                conexion.Comando.Parameters.AddWithValue("@fechaCreacion",nuevo.FechaCreacion);
             
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
