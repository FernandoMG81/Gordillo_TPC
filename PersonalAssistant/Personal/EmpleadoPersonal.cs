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
        public IList<Empleado> listar()
        {
            List<Empleado> lista = new List<Empleado>();
            Empleado aux;
            Conexion conexion;
            try
            {
                conexion = new Conexion();
                //conexion.setearConsulta("select legajo,fecAlta,IDcontrato, IDseccion,IDconcepto,IDconvenio,IDcategoria,nombre," +
                //   "apellido,fechaNac,dni,cuil,nacionalidad,IDestadoCivil,hijos,domicilio,entreCalle1,entreCalle2,cp from empleado");


                conexion.setearConsulta("select Idregistro,emp.legajo, emp.fecAlta, emp.sexo, con.IDcontrato, con.contrato, sec.IDseccion, sec.seccion, ccp.IDconcepto, ccp.concepto, cvn.IDconvenio, " +
                    "cvn.convenio, cat.IDcategoria, cat.categoria, emp.obraSocial, emp.nombre, emp.apellido, emp.fechaNac, emp.dni, emp.cuil, emp.telPrincipal,emp.telSecundario, emp.nacionalidad, " +
                    "etc.IDestadoCivil, etc.estado, emp.hijos, emp.domicilio, emp.entreCalle1, emp.entreCalle2, loc.cp, loc.IDlocalidad, loc.localidad, loc.IDpartido, par.partido," +
                    "emp.basico, emp.telefonoAsignado, emp.controlHorario from empleado emp, contrato con, seccion sec, concepto ccp, convenio cvn, categoria cat, estadoCivil etc, localidad loc, partido par " +
                    "where emp.IDcontrato = con.IDcontrato and emp.IDseccion = sec.IDseccion and emp.IDconcepto = ccp.IDconcepto and emp.IDconvenio = cvn.IDconvenio and " +
                    "emp.IDcategoria = cat.IDcategoria and emp.IDestadoCivil = etc.IDestadoCivil and emp.IDlocalidad = loc.IDlocalidad and loc.IDpartido = par.IDpartido");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Empleado();
                    if (!conexion.Lector.IsDBNull(1))
                    {
                        aux.Legajo = (Int64)conexion.Lector["legajo"];

                    }
                    aux.IDregistro = (long)conexion.Lector["Idregistro"];
                    aux.FechaAlta = (DateTime)conexion.Lector["fecAlta"];
                    aux.Sexo = Convert.ToChar(conexion.Lector["sexo"]); //(char)conexion.Lector["sexo"];
                    aux.Contrato = new Contrato();
                    aux.Contrato.Idcontrato = (Int64)conexion.Lector["IDcontrato"];
                    aux.Contrato.Descripcion = (string)conexion.Lector["contrato"];
                    aux.Seccion = new Seccion();
                    aux.Seccion.Idseccion = (Int64)conexion.Lector["IDseccion"];
                    aux.Seccion.Nombre = (string)conexion.Lector["seccion"];
                    aux.Concepto = new Concepto();
                    aux.Concepto.IdConcepto = (Int64)conexion.Lector["IDconcepto"];
                    aux.Concepto.Nombre = (string)conexion.Lector["concepto"];
                    aux.Convenio = new Convenio();
                    aux.Convenio.IDconvenio = (Int64)conexion.Lector["IDconvenio"];
                    aux.Convenio.Descripcion = (string)conexion.Lector["convenio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Idcategoria = (Int64)conexion.Lector["IDcategoria"];
                    aux.Categoria.nombre = (string)conexion.Lector["categoria"];
                    aux.ObraSocial = (string)conexion.Lector["obraSocial"];
                    aux.Nombre = (string)conexion.Lector["nombre"];
                    aux.Apellido = (string)conexion.Lector["apellido"];
                    aux.FechaDeNacimiento = (DateTime)conexion.Lector["fechaNac"];
                    aux.Dni = (string)conexion.Lector["dni"];
                    aux.Cuil = (string)conexion.Lector["cuil"];
                    aux.Nacionalidad = (string)conexion.Lector["nacionalidad"];
                    aux.EstadoCivil = new EstadoCivil();
                    aux.EstadoCivil.IdEstadoCivil = (byte)conexion.Lector["IDestadoCivil"];
                    aux.EstadoCivil.Descripcion = (string)conexion.Lector["estado"];
                    aux.Hijos = (int)conexion.Lector["hijos"];
                    aux.Domicilio = (string)conexion.Lector["domicilio"];
                    aux.Entrecalle1 = (string)conexion.Lector["entreCalle1"];
                    aux.Entrecalle2 = (string)conexion.Lector["entreCalle2"];
                    aux.Localidad = new Localidad();
                    aux.Localidad.cp = (Int64)conexion.Lector["CP"];
                    aux.Localidad.Nombre = (string)conexion.Lector["localidad"];
                    aux.Localidad.IDlocalidad = (Int64)conexion.Lector["IDlocalidad"];
                    aux.Localidad.IDpartido = (Int64)conexion.Lector["IDpartido"];
                    aux.TelefonoPrincipal = (string)conexion.Lector["telPrincipal"];
                    aux.TelefonoSecundario = (string)conexion.Lector["telSecundario"];
                    aux.Basico = (decimal)conexion.Lector["basico"];
                    aux.TelefonoAsignado = (bool)conexion.Lector["telefonoAsignado"];
                    aux.ControlHorario = (bool)conexion.Lector["controlHorario"];

                    lista.Add(aux);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }

        public IList<Empleado> listarDeposito()
        {
            List<Empleado> lista = new List<Empleado>();
            Empleado aux;
            Conexion conexion;
            try
            {
                conexion = new Conexion();
 
                conexion.setearConsulta("select Idregistro,emp.legajo, emp.fecAlta, emp.sexo, con.IDcontrato, con.contrato, sec.IDseccion, sec.seccion, ccp.IDconcepto, ccp.concepto, cvn.IDconvenio, " +
                    "cvn.convenio, cat.IDcategoria, cat.categoria, emp.obraSocial, emp.nombre, emp.apellido, emp.fechaNac, emp.dni, emp.cuil, emp.telPrincipal,emp.telSecundario, emp.nacionalidad, " +
                    "etc.IDestadoCivil, etc.estado, emp.hijos, emp.domicilio, emp.entreCalle1, emp.entreCalle2, loc.cp, loc.IDlocalidad, loc.localidad, loc.IDpartido, par.partido," +
                    "emp.basico, emp.telefonoAsignado, emp.controlHorario from empleado emp, contrato con, seccion sec, concepto ccp, convenio cvn, categoria cat, estadoCivil etc, localidad loc, partido par " +
                    "where emp.IDcontrato = con.IDcontrato and emp.IDseccion = sec.IDseccion and emp.IDconcepto = ccp.IDconcepto and emp.IDconvenio = cvn.IDconvenio and " +
                    "emp.IDcategoria = cat.IDcategoria and emp.IDestadoCivil = etc.IDestadoCivil and emp.IDlocalidad = loc.IDlocalidad and loc.IDpartido = par.IDpartido");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Empleado();
                    if (!conexion.Lector.IsDBNull(1)) aux.Legajo = (Int64)conexion.Lector["legajo"];
                    if (!conexion.Lector.IsDBNull(21)) aux.TelefonoSecundario = (string)conexion.Lector["telSecundario"];
                    if (!conexion.Lector.IsDBNull(27)) aux.Entrecalle1 = (string)conexion.Lector["entreCalle1"];
                    if (!conexion.Lector.IsDBNull(28)) aux.Entrecalle2 = (string)conexion.Lector["entreCalle2"];
                    /*if (!conexion.Lector.IsDBNull(36))
                    {
                        aux.UsuarioCreacion = (string)conexion.Lector["usuarioCreacion"];
                        aux.UsuarioModificacion = (string)conexion.Lector["usuarioModificacion"];
                        aux.FechaCreacion = (DateTime)conexion.Lector["fechaCreacion"];
                        aux.FechaModificacion = (DateTime)conexion.Lector["fechaModificacion"];
                    }*/
                    aux.IDregistro = (long)conexion.Lector["Idregistro"];
                    aux.FechaAlta = (DateTime)conexion.Lector["fecAlta"];
                    aux.Sexo = Convert.ToChar(conexion.Lector["sexo"]);
                    aux.Contrato = new Contrato();
                    aux.Contrato.Idcontrato = (Int64)conexion.Lector["IDcontrato"];
                    aux.Contrato.Descripcion = (string)conexion.Lector["contrato"];
                    aux.Seccion = new Seccion();
                    aux.Seccion.Idseccion = (Int64)conexion.Lector["IDseccion"];
                    aux.Seccion.Nombre = (string)conexion.Lector["seccion"];
                    aux.Concepto = new Concepto();
                    aux.Concepto.IdConcepto = (Int64)conexion.Lector["IDconcepto"];
                    aux.Concepto.Nombre = (string)conexion.Lector["concepto"];
                    aux.Convenio = new Convenio();
                    aux.Convenio.IDconvenio = (Int64)conexion.Lector["IDconvenio"];
                    aux.Convenio.Descripcion = (string)conexion.Lector["convenio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Idcategoria = (Int64)conexion.Lector["IDcategoria"];
                    aux.Categoria.nombre = (string)conexion.Lector["categoria"];
                    aux.ObraSocial = (string)conexion.Lector["obraSocial"];
                    aux.Nombre = (string)conexion.Lector["nombre"];
                    aux.Apellido = (string)conexion.Lector["apellido"];
                    aux.FechaDeNacimiento = (DateTime)conexion.Lector["fechaNac"];
                    aux.Dni = (string)conexion.Lector["dni"];
                    aux.Cuil = (string)conexion.Lector["cuil"];
                    aux.Nacionalidad = (string)conexion.Lector["nacionalidad"];
                    aux.EstadoCivil = new EstadoCivil();
                    aux.EstadoCivil.IdEstadoCivil = (byte)conexion.Lector["IDestadoCivil"];
                    aux.EstadoCivil.Descripcion = (string)conexion.Lector["estado"];
                    aux.Hijos = (int)conexion.Lector["hijos"];
                    aux.Domicilio = (string)conexion.Lector["domicilio"];
                    //aux.Entrecalle1 = (string)conexion.Lector["entreCalle1"];
                    //aux.Entrecalle2 = (string)conexion.Lector["entreCalle2"];
                    aux.Localidad = new Localidad();
                    aux.Localidad.cp = (Int64)conexion.Lector["CP"];
                    aux.Localidad.Nombre = (string)conexion.Lector["localidad"];
                    aux.Localidad.IDlocalidad = (Int64)conexion.Lector["IDlocalidad"];
                    aux.Localidad.IDpartido = (Int64)conexion.Lector["IDpartido"];
                    aux.TelefonoPrincipal = (string)conexion.Lector["telPrincipal"];
                    //aux.TelefonoSecundario = (string)conexion.Lector["telSecundario"];
                    aux.Basico = (decimal)conexion.Lector["basico"];
                    aux.TelefonoAsignado = (bool)conexion.Lector["telefonoAsignado"];
                    aux.ControlHorario = (bool)conexion.Lector["controlHorario"];

                    lista.Add(aux);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }

        public IList<Empleado> listarLibres()
        {
            List<Empleado> lista = new List<Empleado>();
            Empleado aux;
            Conexion conexion;
            try
            {
                conexion = new Conexion();

                conexion.setearConsulta("select Idregistro,emp.legajo, emp.fecAlta, emp.sexo, con.IDcontrato, con.contrato, sec.IDseccion, sec.seccion, ccp.IDconcepto, ccp.concepto, cvn.IDconvenio, " +
                    "cvn.convenio, cat.IDcategoria, cat.categoria, emp.obraSocial, emp.nombre, emp.apellido, emp.fechaNac, emp.dni, emp.cuil, emp.telPrincipal,emp.telSecundario, emp.nacionalidad, " +
                    "etc.IDestadoCivil, etc.estado, emp.hijos, emp.domicilio, emp.entreCalle1, emp.entreCalle2, loc.cp, loc.IDlocalidad, loc.localidad, loc.IDpartido, par.partido," +
                    "emp.basico,emp.telefonoAsignado from empleado emp, contrato con, seccion sec, concepto ccp, convenio cvn, categoria cat, estadoCivil etc, localidad loc, partido par " +
                    "where emp.IDcontrato = con.IDcontrato and emp.IDseccion = sec.IDseccion and emp.IDconcepto = ccp.IDconcepto and emp.IDconvenio = cvn.IDconvenio and " +
                    "emp.IDcategoria = cat.IDcategoria and emp.IDestadoCivil = etc.IDestadoCivil and emp.IDlocalidad = loc.IDlocalidad and loc.IDpartido = par.IDpartido and emp.controlHorario = 1");
                conexion.abrirConexion();
                conexion.ejecutarAccion();

                while (conexion.Lector.Read())
                {
                    aux = new Empleado();
                    if (!conexion.Lector.IsDBNull(1)) aux.Legajo = (Int64)conexion.Lector["legajo"];
                    if (!conexion.Lector.IsDBNull(21)) aux.TelefonoSecundario = (string)conexion.Lector["telSecundario"];
                    if (!conexion.Lector.IsDBNull(27)) aux.Entrecalle1 = (string)conexion.Lector["entreCalle1"];
                    if (!conexion.Lector.IsDBNull(28)) aux.Entrecalle2 = (string)conexion.Lector["entreCalle2"];
                    /*if (!conexion.Lector.IsDBNull(36))
                    {
                        aux.UsuarioCreacion = (string)conexion.Lector["usuarioCreacion"];
                        aux.UsuarioModificacion = (string)conexion.Lector["usuarioModificacion"];
                        aux.FechaCreacion = (DateTime)conexion.Lector["fechaCreacion"];
                        aux.FechaModificacion = (DateTime)conexion.Lector["fechaModificacion"];
                    }*/
                        aux.IDregistro = (long)conexion.Lector["Idregistro"];
                    aux.FechaAlta = (DateTime)conexion.Lector["fecAlta"];
                    aux.Sexo = Convert.ToChar(conexion.Lector["sexo"]);
                    aux.Contrato = new Contrato();
                    aux.Contrato.Idcontrato = (Int64)conexion.Lector["IDcontrato"];
                    aux.Contrato.Descripcion = (string)conexion.Lector["contrato"];
                    aux.Seccion = new Seccion();
                    aux.Seccion.Idseccion = (Int64)conexion.Lector["IDseccion"];
                    aux.Seccion.Nombre = (string)conexion.Lector["seccion"];
                    aux.Concepto = new Concepto();
                    aux.Concepto.IdConcepto = (Int64)conexion.Lector["IDconcepto"];
                    aux.Concepto.Nombre = (string)conexion.Lector["concepto"];
                    aux.Convenio = new Convenio();
                    aux.Convenio.IDconvenio = (Int64)conexion.Lector["IDconvenio"];
                    aux.Convenio.Descripcion = (string)conexion.Lector["convenio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Idcategoria = (Int64)conexion.Lector["IDcategoria"];
                    aux.Categoria.nombre = (string)conexion.Lector["categoria"];
                    aux.ObraSocial = (string)conexion.Lector["obraSocial"];
                    aux.Nombre = (string)conexion.Lector["nombre"];
                    aux.Apellido = (string)conexion.Lector["apellido"];
                    aux.FechaDeNacimiento = (DateTime)conexion.Lector["fechaNac"];
                    aux.Dni = (string)conexion.Lector["dni"];
                    aux.Cuil = (string)conexion.Lector["cuil"];
                    aux.Nacionalidad = (string)conexion.Lector["nacionalidad"];
                    aux.EstadoCivil = new EstadoCivil();
                    aux.EstadoCivil.IdEstadoCivil = (byte)conexion.Lector["IDestadoCivil"];
                    aux.EstadoCivil.Descripcion = (string)conexion.Lector["estado"];
                    aux.Hijos = (int)conexion.Lector["hijos"];
                    aux.Domicilio = (string)conexion.Lector["domicilio"];
                    //aux.Entrecalle1 = (string)conexion.Lector["entreCalle1"];
                    //aux.Entrecalle2 = (string)conexion.Lector["entreCalle2"];
                    aux.Localidad = new Localidad();
                    aux.Localidad.cp = (Int64)conexion.Lector["CP"];
                    aux.Localidad.Nombre = (string)conexion.Lector["localidad"];
                    aux.Localidad.IDlocalidad = (Int64)conexion.Lector["IDlocalidad"];
                    aux.Localidad.IDpartido = (Int64)conexion.Lector["IDpartido"];
                    aux.TelefonoPrincipal = (string)conexion.Lector["telPrincipal"];
                    //aux.TelefonoSecundario = (string)conexion.Lector["telSecundario"];
                    aux.Basico = (decimal)conexion.Lector["basico"];
                    aux.TelefonoAsignado = (bool)conexion.Lector["telefonoAsignado"];
                    

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

            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("insert into empleado (fecAlta,sexo,IDcontrato,IDseccion,IDconcepto,IDconvenio,IDcategoria,obraSocial,nombre,apellido,fechaNac,dni,cuil,telPrincipal,telSecundario,nacionalidad," +
                    "IDestadoCivil,hijos,Domicilio,entrecalle1,entrecalle2,IDlocalidad,basico,telefonoAsignado,controlHorario)" +
                    "values (@fecAlta,@sexo,@IDcontrato,@IDseccion,@IDconcepto,@IDconvenio,@IDcategoria,@obraSocial,@nombre,@apellido,@fechaNac,@dni,@cuil,@telPrincipal,@telSecundario," +
                    "@nacionalidad,@IDestadoCivil,@hijos,@Domicilio,@entrecalle1,@entrecalle2,@IDlocalidad,@basico,@telefonoAsignado,@controlHorario)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@fecAlta", nuevo.FechaAlta);
                conexion.Comando.Parameters.AddWithValue("@sexo", nuevo.Sexo);
                conexion.Comando.Parameters.AddWithValue("@IDcontrato", nuevo.Contrato.Idcontrato);
                conexion.Comando.Parameters.AddWithValue("@IDseccion", nuevo.Seccion.Idseccion);
                conexion.Comando.Parameters.AddWithValue("@IDconcepto", nuevo.Concepto.IdConcepto);
                conexion.Comando.Parameters.AddWithValue("@IDconvenio", nuevo.Convenio.IDconvenio);
                conexion.Comando.Parameters.AddWithValue("@IDcategoria", nuevo.Categoria.Idcategoria);
                conexion.Comando.Parameters.AddWithValue("@obraSocial", nuevo.ObraSocial);
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@fechaNac", nuevo.FechaDeNacimiento);
                conexion.Comando.Parameters.AddWithValue("@dni", nuevo.Dni);
                conexion.Comando.Parameters.AddWithValue("@cuil", nuevo.Cuil);
                conexion.Comando.Parameters.AddWithValue("@nacionalidad", nuevo.Nacionalidad);
                conexion.Comando.Parameters.AddWithValue("@IDestadoCivil", nuevo.EstadoCivil.IdEstadoCivil);
                conexion.Comando.Parameters.AddWithValue("@hijos", nuevo.Hijos);
                conexion.Comando.Parameters.AddWithValue("@Domicilio", nuevo.Domicilio);
                conexion.Comando.Parameters.AddWithValue("@entrecalle1", nuevo.Entrecalle1);
                conexion.Comando.Parameters.AddWithValue("@entrecalle2", nuevo.Entrecalle2);
                conexion.Comando.Parameters.AddWithValue("@IDlocalidad", nuevo.Localidad.IDlocalidad);
                conexion.Comando.Parameters.AddWithValue("@basico", nuevo.Basico);
                conexion.Comando.Parameters.AddWithValue("@telPrincipal", nuevo.TelefonoPrincipal);
                conexion.Comando.Parameters.AddWithValue("@telSecundario", nuevo.TelefonoSecundario);
                conexion.Comando.Parameters.AddWithValue("@telefonoAsignado", nuevo.TelefonoAsignado);
                conexion.Comando.Parameters.AddWithValue("@controlHorario", nuevo.ControlHorario);

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

        public void modificar(Empleado nuevo)
        {
            Conexion conexion;
            try
            {
                conexion = new Conexion();
                conexion.setearConsulta("update empleado set fecAlta = @fecAlta, sexo = @sexo, IDcontrato = @IDcontrato, IDseccion = @IDseccion, IDconcepto = @IDconcepto, " +
                    "IDconvenio = @IDconvenio, IDcategoria = @IDcategoria, obraSocial = @obraSocial,nombre = @nombre, apellido = @apellido, fechaNac= @fechaNac, dni = @dni, cuil = @cuil, nacionalidad=@nacionalidad, " +
                    "IDestadoCivil = @IDestadoCivil, hijos=@hijos, Domicilio=@Domicilio, entrecalle1=@entreCalle1, entrecalle2=entreCalle2, IDlocalidad=IDlocalidad, basico=@basico, " +
                    "telPrincipal=@telPrincipal, telSecundario=@telSecundario, controlHorario = @controlHorario where dni = @dni");
                //conexion.setearConsulta("update empleado set nombre = @nombre where dni = @dni");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@fecAlta", nuevo.FechaAlta);
                conexion.Comando.Parameters.AddWithValue("@sexo", nuevo.Sexo);
                conexion.Comando.Parameters.AddWithValue("@IDcontrato", nuevo.Contrato.Idcontrato);
                conexion.Comando.Parameters.AddWithValue("@IDseccion", nuevo.Seccion.Idseccion);
                conexion.Comando.Parameters.AddWithValue("@IDconcepto", nuevo.Concepto.IdConcepto);
                conexion.Comando.Parameters.AddWithValue("@IDconvenio", nuevo.Convenio.IDconvenio);
                conexion.Comando.Parameters.AddWithValue("@IDcategoria", nuevo.Categoria.Idcategoria);
                conexion.Comando.Parameters.AddWithValue("@obraSocial", nuevo.ObraSocial);
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@fechaNac", nuevo.FechaDeNacimiento);
                conexion.Comando.Parameters.AddWithValue("@dni", nuevo.Dni);
                conexion.Comando.Parameters.AddWithValue("@cuil", nuevo.Cuil);
                conexion.Comando.Parameters.AddWithValue("@nacionalidad", nuevo.Nacionalidad);
                conexion.Comando.Parameters.AddWithValue("@IDestadoCivil", nuevo.EstadoCivil.IdEstadoCivil);
                conexion.Comando.Parameters.AddWithValue("@hijos", nuevo.Hijos);
                conexion.Comando.Parameters.AddWithValue("@Domicilio", nuevo.Domicilio);
                conexion.Comando.Parameters.AddWithValue("@entrecalle1", nuevo.Entrecalle1);
                conexion.Comando.Parameters.AddWithValue("@entrecalle2", nuevo.Entrecalle2);
                conexion.Comando.Parameters.AddWithValue("@IDlocalidad", nuevo.Localidad.IDlocalidad);
                conexion.Comando.Parameters.AddWithValue("@basico", nuevo.Basico);
                conexion.Comando.Parameters.AddWithValue("@telPrincipal", nuevo.TelefonoPrincipal);
                conexion.Comando.Parameters.AddWithValue("@telSecundario", nuevo.TelefonoSecundario);
                conexion.Comando.Parameters.AddWithValue("@telefonoAsignado", nuevo.TelefonoAsignado);
                conexion.Comando.Parameters.AddWithValue("@controlHorario", nuevo.ControlHorario);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
