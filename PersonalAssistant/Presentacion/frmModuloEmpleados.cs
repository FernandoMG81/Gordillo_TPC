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

        private void button1_Click(object sender, EventArgs e)
        {
            frmAsignarEquipos asignarEquipo = new frmAsignarEquipos();
            AbrirFormHijo(asignarEquipo);
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado empleado = new frmAltaEmpleado();
            AbrirFormHijo(empleado);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado modificar = new frmModificarEmpleado();
            AbrirFormHijo(modificar);
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            frmLicencias licencias = new frmLicencias();
            AbrirFormHijo(licencias);
        }

        private void btnConvenio_Click(object sender, EventArgs e)
        {
            frmVacaciones vacaciones = new frmVacaciones();
            AbrirFormHijo(vacaciones);
        }
    }
}
