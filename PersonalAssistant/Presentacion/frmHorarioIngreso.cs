using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personal;
using Dominio;

namespace Presentacion
{
    public partial class frmHorarioIngreso : Form
    {
        public frmHorarioIngreso()
        {
            InitializeComponent();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            lblSegundos.Text = DateTime.Now.ToString("ss");
            cbar.Value = Convert.ToInt32(DateTime.Now.ToString("ss"));
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

        }

        private void frmHorarioIngreso_Load(object sender, EventArgs e)
        {
            EmpleadoPersonal empleados;
            horarioPersonal horario;
            try
            {
                horario = new horarioPersonal();
                empleados = new EmpleadoPersonal();
                dgvListaDeposito.DataSource = horario.listarIngreso();
                dgvListaDeposito.Columns["Idregistro"].Visible = false;
                dgvListaDeposito.Columns["legajo"].Visible = false;
                dgvListaDeposito.Columns["fechaAlta"].Visible = false;
                dgvListaDeposito.Columns["sexo"].Visible = false;
                dgvListaDeposito.Columns["contrato"].Visible = false;
                dgvListaDeposito.Columns["concepto"].Visible = false;
                dgvListaDeposito.Columns["seccion"].Visible = false;
                dgvListaDeposito.Columns["convenio"].Visible = false;
                dgvListaDeposito.Columns["categoria"].Visible = false;
                dgvListaDeposito.Columns["obraSocial"].Visible = false;
                dgvListaDeposito.Columns["fechaDeNacimiento"].Visible = false;
                dgvListaDeposito.Columns["dni"].Visible = false;
                dgvListaDeposito.Columns["cuil"].Visible = false;
                dgvListaDeposito.Columns["telefonoPrincipal"].Visible = false;
                dgvListaDeposito.Columns["telefonoSecundario"].Visible = false;
                dgvListaDeposito.Columns["nacionalidad"].Visible = false;
                dgvListaDeposito.Columns["estadoCivil"].Visible = false;
                dgvListaDeposito.Columns["hijos"].Visible = false;
                dgvListaDeposito.Columns["domicilio"].Visible = false;
                dgvListaDeposito.Columns["entreCalle1"].Visible = false;
                dgvListaDeposito.Columns["entreCalle2"].Visible = false;
                dgvListaDeposito.Columns["localidad"].Visible = false;
                dgvListaDeposito.Columns["basico"].Visible = false;
                dgvListaDeposito.Columns["edad"].Visible = false;
                dgvListaDeposito.Columns["vencimientoPrueba"].Visible = false;
                dgvListaDeposito.Columns["baja"].Visible = false;
                dgvListaDeposito.Columns["Apellido"].DisplayIndex = 0;
                dgvListaDeposito.Columns["nombre"].DisplayIndex = 1;
                dgvListaDeposito.Columns["TelefonoAsignado"].Visible = false;
                dgvListaDeposito.Columns["ControlHorario"].Visible = false;
                dgvListaDeposito.Columns["FechaCreacion"].Visible = false;
                dgvListaDeposito.Columns["UsuarioCreacion"].Visible = false;
                dgvListaDeposito.Columns["FechaModificacion"].Visible = false;
                dgvListaDeposito.Columns["UsuarioModificacion"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Empleado ingreso;
            Conexion conexion = null;
            long prueba = 9;
            try
            {
                conexion = new Conexion();
                ingreso = new Empleado();
                ingreso = (Empleado)dgvListaDeposito.CurrentRow.DataBoundItem;
                conexion.setearConsulta("exec sp_registro_ingreso @dni, @IDusuarioIngreso");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@dni",ingreso.Dni);
                conexion.Comando.Parameters.AddWithValue("@IDusuarioIngreso", prueba); //TODO:modificar cuando se realice lo de usuarios

                conexion.abrirConexion();
                conexion.ejecutarAccion();
                frmHorarioIngreso_Load(sender, e);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            finally
            {
                if (conexion!=null)
                {
                    conexion.cerrarConexion();
                }
            }
        }
    }
}
