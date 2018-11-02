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
    public partial class frmHorarioSalida : Form
    {
        public frmHorarioSalida()
        {
            InitializeComponent();
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            lblSegundos.Text = DateTime.Now.ToString("ss");
            cbar.Value = Convert.ToInt32(DateTime.Now.ToString("ss"));
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void frmHorarioSalida_Load(object sender, EventArgs e)
        {
            EmpleadoPersonal empleados;
            horarioPersonal horario;
            try
            {
                horario = new horarioPersonal();
                empleados = new EmpleadoPersonal();
                dgvListaDeposito.DataSource = horario.listarSalida();
                dgvListaDeposito.Columns["IDregistro"].Visible = false;
                dgvListaDeposito.Columns["dni"].Visible = false;
                dgvListaDeposito.Columns["salida"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Horario salida;
            Conexion conexion = null;
            long prueba = 9;
            try
            {
                conexion = new Conexion();
                salida  = new Horario();
                salida = (Horario)dgvListaDeposito.CurrentRow.DataBoundItem;
                conexion.setearConsulta("exec sp_registro_salida @IdregistroHorario, @dni, @IDusuarioSalida");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IDregistroHorario", salida.IDregistro);
                conexion.Comando.Parameters.AddWithValue("@dni", salida.dni);
                conexion.Comando.Parameters.AddWithValue("@IDusuarioSalida", prueba); //TODO:modificar cuando se realice lo de usuarios

                conexion.abrirConexion();
                conexion.ejecutarAccion();
                frmHorarioSalida_Load(sender, e);

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
