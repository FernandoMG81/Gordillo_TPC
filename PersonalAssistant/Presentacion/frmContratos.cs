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
    public partial class frmContratos : Form
    {
        protected override void OnShown(EventArgs e)
        {
            dgvListaConvenios.ClearSelection();
            base.OnShown(e);
        }

        public frmContratos()
        {
            InitializeComponent();
        }

        private void txbContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

       
        private void frmContratos_Load(object sender, EventArgs e)
        {
            ContratoPersonal contratos;
            try
            {
                contratos = new ContratoPersonal();
                dgvListaConvenios.DataSource = contratos.listar();
                dgvListaConvenios.Columns["Idcontrato"].Visible = false;
                dgvListaConvenios.Columns["Descripcion"].HeaderText = "CONTRATOS";

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ContratoPersonal contratos;
            Contrato nuevo;
            try
            {
                contratos = new ContratoPersonal();
                nuevo = new Contrato();
                nuevo.Descripcion = txbContrato.Text.ToUpper().Trim();
                contratos.alta(nuevo);

                frmContratos_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Escriba el nombre para ingresar");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ContratoPersonal contratos;
            Contrato baja;

            try
            {
                frmConfirma confirma = new frmConfirma("Seguro que desea eliminar el contrato");
                confirma.ShowDialog();

                if (confirma.Confirma == true)
                {
                    contratos = new ContratoPersonal();
                    baja = new Contrato();
                    baja = (Contrato)dgvListaConvenios.CurrentRow.DataBoundItem;
                    contratos.eliminar(baja);

                    frmContratos_Load(sender, e);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione el que quiere eliminar");
            }
        }
    }
}
