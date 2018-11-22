using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using Personal;

namespace Presentacion
{
    public partial class frmModuloHorarios : frmModelo
    {
        private Usuario usuarioLogueado;

        public frmModuloHorarios(Usuario user)
        {
            InitializeComponent();
            usuarioLogueado = user;
        }

        private void AbrirFormHijo(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }
        private void btnAltaUsuarios_Click(object sender, EventArgs e)
        {
            frmHorarioIngreso ingreso = new frmHorarioIngreso(usuarioLogueado);
            AbrirFormHijo(ingreso);

        }

        private void btnAltaEquipos_Click(object sender, EventArgs e)
        {
            frmHorarioSalida salida = new frmHorarioSalida(usuarioLogueado);
            AbrirFormHijo(salida);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReporteHorario reporte = new frmReporteHorario();
            reporte.ShowDialog();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            frmInformeHorario informe = new frmInformeHorario();
            AbrirFormHijo(informe);
        }
    }
}
