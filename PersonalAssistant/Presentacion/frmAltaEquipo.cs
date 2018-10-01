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
    public partial class frmAltaEquipo : Form
    {
        public frmAltaEquipo()
        {
            InitializeComponent();
        }

        private void frmAltaEquipo_Load(object sender, EventArgs e)
        {
            EquipoTelefonoPersonal equipo = new EquipoTelefonoPersonal();
            try
            {
            dgvListaEquipos.DataSource = equipo.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EquipoTelefonoPersonal equipo = new EquipoTelefonoPersonal();
            EquipoTelefono nuevo = new EquipoTelefono();

            try
            {
                nuevo.Imei = txbIMEI.Text;
                nuevo.Modelo = txbModelo.Text;
                nuevo.Marca = txbMarca.Text;
                nuevo.Comentario = txbComentario.Text;
                nuevo.Disponible = true;

                equipo.alta(nuevo);
                frmAltaEquipo_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                txbIMEI.Text = "";
                txbMarca.Text = "";
                txbModelo.Text = "";
                txbComentario.Text = "";
                txbIMEI.Focus();

            }
        }
    }
}
