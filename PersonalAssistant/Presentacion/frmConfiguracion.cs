using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmConfiguracion : frmModelo
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

     private void AbrirFormHijo (object formHijo)
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
            frmAltaUsuario altaUsuario = new frmAltaUsuario();
            AbrirFormHijo(altaUsuario);
            altaUsuario.Focus();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            AbrirFormHijo(categoria);
            categoria.Focus();
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            frmContratos contratos = new frmContratos();
            AbrirFormHijo(contratos);
            contratos.Focus();
        }

        private void btnConvenio_Click(object sender, EventArgs e)
        {
            frmConvenio convenio = new frmConvenio();
            AbrirFormHijo(convenio);
            convenio.Focus();
        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {
            frmCiudades ciudades = new frmCiudades();
            AbrirFormHijo(ciudades);
            ciudades.Focus();
        }

        private void btnAltaEquipos_Click(object sender, EventArgs e)
        {
            frmAltaEquipo altaEquipo = new frmAltaEquipo();
            AbrirFormHijo(altaEquipo);
            altaEquipo.Focus();
        }
    }
}
