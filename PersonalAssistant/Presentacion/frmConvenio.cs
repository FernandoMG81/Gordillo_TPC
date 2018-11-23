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
    public partial class frmConvenio : Form
    {
        protected override void OnShown(EventArgs e)
        {
            dgvListaConvenios.ClearSelection();
            base.OnShown(e);
        }

        public frmConvenio()
        {
            InitializeComponent();
        }

        private void frmConvenio_Load(object sender, EventArgs e)
        {
            ConvenioPersonal convenios;
            try
            {
                convenios = new ConvenioPersonal();
                dgvListaConvenios.DataSource = convenios.listar();
                dgvListaConvenios.Columns["Idconvenio"].Visible = false;
                dgvListaConvenios.Columns["Descripcion"].HeaderText = "CONVENIOS";

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void txbConvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ConvenioPersonal convenios;
            Convenio nuevo;
            try
            {
                convenios = new ConvenioPersonal();
                nuevo = new Convenio();
                nuevo.Descripcion = txbConvenio.Text.ToUpper().Trim();
                convenios.alta(nuevo);

                frmConvenio_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Escriba el nombre para ingresar");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ConvenioPersonal convenios;
            Convenio baja;

            try
            {
                frmConfirma confirma = new frmConfirma("Seguro que desea eliminar el convenio");
                confirma.ShowDialog();

                if (confirma.Confirma == true)
                {
                    convenios = new ConvenioPersonal();
                    baja = new Convenio();
                    baja = (Convenio)dgvListaConvenios.CurrentRow.DataBoundItem;
                    convenios.eliminar(baja);

                    frmConvenio_Load(sender, e);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione el que quiere eliminar");
            }
        }
    }
}
