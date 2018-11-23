using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Personal;

namespace Presentacion
{
    public partial class frmAsignarEquipos : Form
    {
        protected override void OnShown(EventArgs e)
        {
            dgvAsignados.ClearSelection();
            dgvListaEmpleados.ClearSelection();
            dgvListaEquipos.ClearSelection();
            base.OnShown(e);
        }


        public string Comentario { get; set; }
        private List<Empleado> listaEmpleados;
        private List<EquipoTelefono> listaEquipos;
        private List<equipoXusuario> listaAsignados;
        public frmAsignarEquipos()
        {
            InitializeComponent();

        }

        
        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txbBuscar.Text == "")
            {
                dgvListaEmpleados.DataSource = listaEmpleados;
            }
            else
            {
                List<Empleado> listaEmp;
                listaEmp = listaEmpleados.FindAll(FIND => FIND.Apellido.ToLower().Contains(txbBuscar.Text.ToLower()));
                dgvListaEmpleados.DataSource = listaEmp;
            }
        }

        private void cargarEquipos()
        {
            EquipoTelefonoPersonal Equipos = new EquipoTelefonoPersonal();
            try
            {
                listaEquipos = (List<EquipoTelefono>)Equipos.ListarLibres();
                dgvListaEquipos.DataSource = listaEquipos;
                dgvListaEquipos.Columns["disponible"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarAsignados()
        {
            equipoXusuarioPersonal asignados = new equipoXusuarioPersonal();
            try
            {
                listaAsignados = (List<equipoXusuario>)asignados.listarAsignados();
                dgvAsignados.DataSource = listaAsignados;
                dgvAsignados.Columns["fechaBaja"].Visible = false;
                dgvAsignados.Columns["Aempleado"].HeaderText = "Apellido";
                dgvAsignados.Columns["Nempleado"].HeaderText = "Nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void cargarEmpleados()
        {
            EmpleadoPersonal empleados = new EmpleadoPersonal();
            try
            {
                listaEmpleados = (List<Empleado>)empleados.listarLibres();
                dgvListaEmpleados.DataSource = listaEmpleados;
                dgvListaEmpleados.Columns["Idregistro"].Visible = false;
                dgvListaEmpleados.Columns["legajo"].Visible = false;
                dgvListaEmpleados.Columns["fechaAlta"].Visible = false;
                dgvListaEmpleados.Columns["sexo"].Visible = false;
                dgvListaEmpleados.Columns["contrato"].Visible = false;
                dgvListaEmpleados.Columns["concepto"].Visible = false;
                dgvListaEmpleados.Columns["seccion"].Visible = false;
                dgvListaEmpleados.Columns["convenio"].Visible = false;
                dgvListaEmpleados.Columns["categoria"].Visible = false;
                dgvListaEmpleados.Columns["obraSocial"].Visible = false;
                dgvListaEmpleados.Columns["fechaDeNacimiento"].Visible = false;
                dgvListaEmpleados.Columns["dni"].Visible = false;
                dgvListaEmpleados.Columns["cuil"].Visible = false;
                dgvListaEmpleados.Columns["telefonoPrincipal"].Visible = false;
                dgvListaEmpleados.Columns["telefonoSecundario"].Visible = false;
                dgvListaEmpleados.Columns["nacionalidad"].Visible = false;
                dgvListaEmpleados.Columns["estadoCivil"].Visible = false;
                dgvListaEmpleados.Columns["hijos"].Visible = false;
                dgvListaEmpleados.Columns["domicilio"].Visible = false;
                dgvListaEmpleados.Columns["entreCalle1"].Visible = false;
                dgvListaEmpleados.Columns["entreCalle2"].Visible = false;
                dgvListaEmpleados.Columns["localidad"].Visible = false;
                dgvListaEmpleados.Columns["basico"].Visible = false;
                dgvListaEmpleados.Columns["edad"].Visible = false;
                dgvListaEmpleados.Columns["vencimientoPrueba"].Visible = false;
                dgvListaEmpleados.Columns["baja"].Visible = false;
                dgvListaEmpleados.Columns["Apellido"].DisplayIndex = 0;
                dgvListaEmpleados.Columns["nombre"].DisplayIndex = 1;
                dgvListaEmpleados.Columns["TelefonoAsignado"].Visible = false;
                dgvListaEmpleados.Columns["ControlHorario"].Visible = false;
                dgvListaEmpleados.Columns["FechaCreacion"].Visible = false;
                dgvListaEmpleados.Columns["UsuarioCreacion"].Visible = false;
                dgvListaEmpleados.Columns["FechaModificacion"].Visible = false;
                dgvListaEmpleados.Columns["UsuarioModificacion"].Visible = false;
                dgvListaEmpleados.Columns["bajaFecha"].Visible = false;
                dgvListaEmpleados.Columns["Bajamotivo"].Visible = false;
                dgvListaEmpleados.Columns["foto"].Visible = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            Conexion conexion = null;
            
            Empleado aux = new Empleado();
            EquipoTelefono aux2 = new EquipoTelefono();
            
            try
            {
                aux = (Empleado)dgvListaEmpleados.CurrentRow.DataBoundItem;
                aux2 = (EquipoTelefono)dgvListaEquipos.CurrentRow.DataBoundItem;
                conexion = new Conexion();
                conexion.setearConsulta("update empleado set telefonoAsignado = 1 where dni = @dni");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@dni", aux.Dni);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
                conexion.cerrarConexion();

                conexion = new Conexion();
                conexion.setearConsulta("update equipoTelefono set disponible = 0 where IMEI = @IMEI");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IMEI", aux2.Imei);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
                conexion.cerrarConexion();

                frmComentario com = new frmComentario();
                AddOwnedForm(com);
                com.ShowDialog();
                              

                conexion = new Conexion();
                conexion.setearConsulta("insert Tel_x_empleado (Imei,Dni,comentario,fecAlta) values (@IMEI,@dni,@comentario,@fecAlta)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IMEI", aux2.Imei);
                conexion.Comando.Parameters.AddWithValue("@dni", aux.Dni);
                conexion.Comando.Parameters.AddWithValue("@comentario", Comentario);
                conexion.Comando.Parameters.AddWithValue("@fecAlta", DateTime.Now);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
                conexion.cerrarConexion();

                frmAsignarEquipos_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        private void frmAsignarEquipos_Load(object sender, EventArgs e)
        {
            cargarEquipos();
            cargarEmpleados();
            cargarAsignados();

        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            Conexion conexion = null;

            equipoXusuario aux = new equipoXusuario();
            try
            {
                aux = (equipoXusuario)dgvAsignados.CurrentRow.DataBoundItem;
                conexion = new Conexion();
                conexion.setearConsulta("update empleado set telefonoAsignado = 0 where dni = @dni");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@dni", aux.DNI);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
                conexion.cerrarConexion();

                conexion = new Conexion();
                conexion.setearConsulta("update equipoTelefono set disponible = 1 where IMEI = @IMEI");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IMEI", aux.IMEI);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
                conexion.cerrarConexion();

                conexion = new Conexion();
                conexion.setearConsulta("update Tel_x_empleado set fecBaja = @fecBaja where IDregistro=@IDregistro");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IDregistro", aux.IDregistro);
                conexion.Comando.Parameters.AddWithValue("@fecBaja", DateTime.Now);

                conexion.abrirConexion();
                conexion.ejecutarAccion();


                frmAsignarEquipos_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
