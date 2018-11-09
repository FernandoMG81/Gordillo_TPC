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

namespace Presentacion
{
    public partial class frmModuloEmpleados : frmModelo
    {
        public frmModuloEmpleados()
        {
            InitializeComponent();
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


        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado empleado = new frmAltaEmpleado();
            AbrirFormHijo(empleado);
            empleado.Focus();
            pnlBoton.Height = btnAltaEmpleado.Height;
            pnlBoton.Top = btnAltaEmpleado.Top;
            pnlBoton.Show();
        }

        

        private void btnAsignarEquipo_Click(object sender, EventArgs e)
        {
            frmAsignarEquipos asignarEquipo = new frmAsignarEquipos();
            AbrirFormHijo(asignarEquipo);
            pnlBoton.Height = btnAsignarEquipo.Height;
            pnlBoton.Top = btnAsignarEquipo.Top;
            pnlBoton.Show();

        }

        private void btnListaEmpleados_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado modificar = new frmModificarEmpleado();
            AbrirFormHijo(modificar);
            pnlBoton.Height = btnListaEmpleados.Height;
            pnlBoton.Top = btnListaEmpleados.Top;
            pnlBoton.Show();
        }

        private void btnLicencias_Click(object sender, EventArgs e)
        {
            frmLicencias licencias = new frmLicencias();
            AbrirFormHijo(licencias);
            pnlBoton.Height = btnLicencias.Height;
            pnlBoton.Top = btnLicencias.Top;
            pnlBoton.Show();
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            frmVacaciones vacaciones = new frmVacaciones();
            AbrirFormHijo(vacaciones);
            pnlBoton.Height = btnVacaciones.Height;
            pnlBoton.Top = btnVacaciones.Top;
            pnlBoton.Show();
        }
    }
}
