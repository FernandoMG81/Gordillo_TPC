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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            ConceptoPersonal concepto;
            SeccionPersonal seccion;
            CategoriaPersonal categoria;

            try
            {
                concepto = new ConceptoPersonal();
                seccion = new SeccionPersonal();
                categoria = new CategoriaPersonal();
                cbSeccion.DataSource = seccion.listar();
                cbSeccion.ValueMember = "Idseccion";
                cbSeccion.DisplayMember = "Nombre";

                cbConcepto.DataSource = concepto.listar();
                cbConcepto.ValueMember = "Idconcepto";
                cbConcepto.DisplayMember = "Nombre";

                cbCategoria.DataSource = categoria.listar();
                cbCategoria.ValueMember = "Idcategoria";
                cbCategoria.DisplayMember = "nombre";

                cbSeccion.Text = "";
                cbCategoria.Text = "";
                cbConcepto.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
