﻿using System;
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
                comando.CommandText = "select u.Idregistro, u.nombre, u.clave, u.sexo, tp.descripcion, tp.Idtipo from usuarios u inner join tipoUsuario tp on u.Idtipo = tp.Idtipo";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Usuario();
                    aux.ID = (long)lector["Idregistro"];
                    aux.Nombre = (string)lector["nombre"];
                    aux.Password = (string)lector["clave"];
                    aux.Sexo = Convert.ToChar(lector["sexo"]);
                    aux.Tipo = new TipoUsuario();
                    aux.Tipo.Id = (byte)lector["Idtipo"];
                    aux.Descripcion = (string)lector["Descripcion"];
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


        public bool validarUsuario(Usuario usuario)
        {
            Conexion conexion;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("select Nombre, Clave, IdTipo from USUARIOS Where Nombre=@Nombre and Clave=@pass");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                conexion.Comando.Parameters.AddWithValue("@pass", usuario.Password);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                if (conexion.Lector.Read())
                {
                    usuario.Nombre = (string)conexion.Lector["Nombre"];
                    usuario.Password = (string)conexion.Lector["Clave"];
                    usuario.Tipo = new TipoUsuario();
                    usuario.Tipo.Id = (byte)conexion.Lector["IdTipo"];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario llenarUsuario(string user)
        {
            Conexion conexion = null;
            Usuario logueado;
            try
            {
                conexion = new Conexion();
                logueado = new Usuario();
                conexion.setearConsulta("select u.idregistro,u.nombre,u.clave,u.sexo,u.idtipo, t.descripcion from usuarios u,tipoUsuario t where u.idtipo = t.idtipo and nombre = '"+user+"'");
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                conexion.Lector.Read();

                logueado.ID = (long)conexion.Lector["Idregistro"];
                logueado.Sexo =Convert.ToChar(conexion.Lector["sexo"]);
                logueado.Nombre = (string)conexion.Lector["Nombre"];
                logueado.Password = (string)conexion.Lector["Clave"];
                logueado.Tipo = new TipoUsuario();
                logueado.Tipo.Id = (byte)conexion.Lector["IdTipo"];
                logueado.Tipo.Descripcion = (string)conexion.Lector["descripcion"];

                return logueado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if(conexion==null)
                conexion.cerrarConexion();
            }
        }

        public void alta(Usuario nuevo)
        {
            Conexion conexion = null;

            try
            {
                conexion = new Conexion();

                conexion.setearConsulta("insert into usuarios (nombre, clave, Idtipo,sexo) values (@nombre,@clave,@Idtipo,@sexo)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@clave", nuevo.Password);
                conexion.Comando.Parameters.AddWithValue("@Idtipo", nuevo.Tipo.Id);
                conexion.Comando.Parameters.AddWithValue("@sexo", nuevo.Sexo);
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
