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
           cargaCBXestado();

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
        }


        public bool validarTextBox ()
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
                txbComentario.Text = "";
                txbIMEI.Focus();

            }
            }
        }

        public void cargaCBXestado()
        {
            DataTable tabla;
            
            SqlDataAdapter adaptador;
            SqlCommand comando;
            string consulta = "";
            try
            {
                tabla = new DataTable();

                using (SqlConnection conexion = new SqlConnection(@"data source =.\SQLEXPRESS;initial catalog = Gordillo_TPC ; integrated security = sspi"))
                {
                    consulta = "select ID, descripcion from estado_telefono";
                    comando = new SqlCommand(consulta, conexion);
                    adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }

                cbxEstado.DisplayMember = "descripcion";
                cbxEstado.DataSource = tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
