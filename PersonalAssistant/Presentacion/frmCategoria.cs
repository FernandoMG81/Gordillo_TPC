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

            try
            {
                //cargarDgvSeccion();
                //cargarDgvConcepto();
                //cargarDgvCategoria();
                cargarSecciones();
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
                long temp = 0;
                if (long.TryParse(cbSeccion.SelectedValue.ToString(), out temp))
                {
                    cargarConceptos((long)cbSeccion.SelectedValue);
                    cargarDgvSeccion((long)cbSeccion.SelectedValue);
                    cargarDgvConcepto((long)cbSeccion.SelectedValue);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarDgvSeccion(long id = 0)
        {
            SeccionPersonal Secciones;
            try
            {
                Secciones = new SeccionPersonal();
                dgvSeccion.DataSource = Secciones.listar(id);
                dgvSeccion.Columns["IdSeccion"].Visible = false;
                dgvSeccion.ClearSelection();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarDgvConcepto(long ID = 0)
        {
            ConceptoPersonal Conceptos;
            try
            {
                Conceptos = new ConceptoPersonal();
                dgvConcepto.DataSource = Conceptos.listar(ID);
                dgvConcepto.Columns["IdConcepto"].Visible = false;
                dgvConcepto.Columns["IdArea"].Visible = false;
                dgvConcepto.ClearSelection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarDgvCategoria(long ID=0)
        {
            CategoriaPersonal Categorias;
            try
            {
                Categorias = new CategoriaPersonal();
                dgvCategoria.DataSource = Categorias.listar(ID);
                dgvCategoria.Columns["IdCategoria"].Visible = false;
                dgvCategoria.Columns["IdConcepto"].Visible = false;
                dgvCategoria.ClearSelection();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarSeccion_Click(object sender, EventArgs e)
        {
            SeccionPersonal secciones;
            Seccion nuevo;
            try
            {
                secciones = new SeccionPersonal();
                nuevo = new Seccion();
                if (txbSeccion.Text == "") MessageBox.Show("Escriba la seccion que desea ingresar");
                else
                {
                    nuevo.Nombre = txbSeccion.Text.ToUpper().Trim();
                    secciones.alta(nuevo);
                    cargarSecciones();
                    txbSeccion.Text = "";

                }
                //frmContratos_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al ingresar la Seccion");
            }
        }

        private void cargarCategorias(long Idcat = 0)
        {
            CategoriaPersonal categoria;

            try
            {
                categoria = new CategoriaPersonal();
                cbCategoria.DataSource = categoria.listar(Idcat);
                cbCategoria.ValueMember = "Idcategoria";
                cbCategoria.DisplayMember = "nombre";
                cbCategoria.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void cargarSecciones()
        {
            SeccionPersonal seccion;

            try
            {
                seccion = new SeccionPersonal();
                cbSeccion.DataSource = seccion.listar();
                cbSeccion.ValueMember = "Idseccion";
                cbSeccion.DisplayMember = "Nombre";
                cbSeccion.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Escriba la seccion que desea ingresar");
            }

        }

        private void cargarConceptos(long ID = 0)
        {
            ConceptoPersonal concepto;

            try
            {
                concepto = new ConceptoPersonal();
                cbConcepto.DataSource = concepto.listar(ID);
                cbConcepto.ValueMember = "Idconcepto";
                cbConcepto.DisplayMember = "Nombre";
                cbConcepto.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void cbConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                long temp = 0;
                if (long.TryParse(cbConcepto.SelectedValue.ToString(), out temp))
                {
                    cargarCategorias((long)cbConcepto.SelectedValue);
                    cargarDgvCategoria((long)cbConcepto.SelectedValue);
                    dgvCategoria.ClearSelection();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarConcepto_Click(object sender, EventArgs e)
        {
            ConceptoPersonal Conceptos;
            Concepto nuevo;
            try
            {
                Conceptos = new ConceptoPersonal();
                nuevo = new Concepto();
                if (txbConcepto.Text == "") MessageBox.Show("Escriba el concepto que desea ingresar");
                else
                {
                    nuevo.Nombre = txbConcepto.Text.ToUpper().Trim();
                    nuevo.IdArea = (long)cbSeccion.SelectedValue;
                    if (cbSeccion.SelectedIndex == 0) MessageBox.Show("Debe seleccionar una seccion para agregar un concepto");
                    else
                    {
                        Conceptos.alta(nuevo);
                        cargarSecciones();
                        cargarConceptos();
                        txbConcepto.Text = "";
                    }
                }
                //frmContratos_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al ingresar el concepto");
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaPersonal Categorias;
            Categoria nuevo;
            try
            {
                Categorias = new CategoriaPersonal();
                nuevo = new Categoria();
                if (txbCategoria.Text == "") MessageBox.Show("Escriba la categoria que desea ingresar");
                else
                {
                    nuevo.nombre = txbCategoria.Text.ToUpper().Trim();
                    nuevo.IdConcepto = (long)cbConcepto.SelectedValue;
                    if (cbSeccion.Text == "") MessageBox.Show("Debe seleccionar una seccion para agregar un concepto");
                    if (cbConcepto.Text == "") MessageBox.Show("Debe seleccionar un concepto para agregar una categoria");
                    else
                    {
                        Categorias.alta(nuevo);
                        cargarSecciones();
                        cargarConceptos();
                        cargarCategorias();
                        txbCategoria.Text = "";
                    }

                }
                //frmContratos_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al ingresar el concepto");
            }
        }

        private void btnBorrarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaPersonal categorias;
            Categoria baja;

            try
            {
                frmConfirma confirma = new frmConfirma("Seguro que desea eliminar la categoria "+dgvCategoria.CurrentCell.Value);
                confirma.ShowDialog();

                if (confirma.Confirma == true)
                {
                    categorias = new CategoriaPersonal();
                    baja = new Categoria();
                    baja = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    categorias.eliminar(baja);

                    frmCategoria_Load(sender, e);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione el que quiere eliminar");
            }
        }

        private void btnBorrarConcepto_Click(object sender, EventArgs e)
        {
            ConceptoPersonal conceptos;
            Concepto baja;

            try
            {
                frmConfirma confirma = new frmConfirma("Seguro que desea eliminar el concepto " + dgvCategoria.CurrentCell.Value + Environment.NewLine + "Y todas sus categorias asociadas");
                confirma.ShowDialog();

                if (confirma.Confirma == true)
                {
                    conceptos = new ConceptoPersonal();
                    baja = new Concepto();
                    baja = (Concepto)dgvConcepto.CurrentRow.DataBoundItem;
                    conceptos.eliminar(baja);

                    frmCategoria_Load(sender, e);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione el que quiere eliminar");
            }
        }

        private void btnBorrarSeccion_Click(object sender, EventArgs e)
        {
            SeccionPersonal secciones;
            Seccion baja;

            try
            {
                frmConfirma confirma = new frmConfirma("Seguro que desea eliminar la seccion " + dgvSeccion.CurrentCell.Value + Environment.NewLine + "Y todos sus conceptos y categorias asociadas");
                confirma.ShowDialog();

                if (confirma.Confirma == true)
                {
                    secciones = new SeccionPersonal();
                    baja = new Seccion();
                    baja = (Seccion)dgvSeccion.CurrentRow.DataBoundItem;
                    secciones.eliminar(baja);

                    frmCategoria_Load(sender, e);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione el que quiere eliminar");
            }
        }
    }
}
