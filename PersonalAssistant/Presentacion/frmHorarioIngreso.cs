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
            try
            {
                empleados = new EmpleadoPersonal();
                dgvListaDeposito.DataSource = empleados.listarDeposito();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
