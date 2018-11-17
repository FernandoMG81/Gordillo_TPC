using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            EstadoTelPersonal estado = new EstadoTelPersonal(); ;
            EquipoTelefonoPersonal equipo = new EquipoTelefonoPersonal();

            try
            {
                cbxEstado.DataSource = estado.listar();
                cbxEstado.ValueMember = "Id";
                cbxEstado.DisplayMember = "Nombre";
                dgvListaEquipos.DataSource = equipo.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }


        public bool validarTextBox()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        //Codigo comprobacion  de textbox
                        if (item.Text == "")
                        {
                            MessageBox.Show("Hay campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                    else if (item is RichTextBox)
                    {
                        //codigo comprobacion de richtextbox
                        if (item.Text == "")
                        {
                            MessageBox.Show("Hay campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                    else if (item is ComboBox)
                    {
                        if (item.Text == "")
                        {
                            MessageBox.Show("Debes seleccionar un item");
                            item.Focus();
                            return false;
                        }
                    }
                }
                catch { }
            }
            return true;

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (validarTextBox())
            {
                EquipoTelefonoPersonal equipo = new EquipoTelefonoPersonal();
                EquipoTelefono nuevo = new EquipoTelefono();

                try
                {
                    nuevo.Imei = txbIMEI.Text;
                    nuevo.Modelo = txbModelo.Text;
                    nuevo.Marca = txbMarca.Text;
                    nuevo.Condicion = cbxEstado.SelectedValue.ToString();
                    //nuevo.Comentario = txbComentario.Text;
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
                    
                    txbIMEI.Focus();

                }
            }
        }

        private void txbIMEI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txbModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void txbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void txbComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void cbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmConfirma confirma;
            EquipoTelefonoPersonal elimina;
            try
            {
                confirma = new frmConfirma("Seguro desear eliminar definitivamente el equipo seleccionado?");
                confirma.ShowDialog();

                if (confirma.Confirma == true)
                {
                    elimina = new EquipoTelefonoPersonal();
                    elimina.baja((EquipoTelefono)dgvListaEquipos.CurrentRow.DataBoundItem);
                    frmAltaEquipo_Load(sender, e);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
