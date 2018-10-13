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
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class frmAltaEmpleado : Form
    {
        public frmAltaEmpleado()
        {
            InitializeComponent();
        }

        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {

            ConceptoPersonal concepto = new ConceptoPersonal();
            CategoriaPersonal categoria = new CategoriaPersonal();
            ContratoPersonal contrato = new ContratoPersonal();
            SeccionPersonal seccion = new SeccionPersonal();
            ConvenioPersonal convenio = new ConvenioPersonal();
            EstadoCivilPersonal estadoCivil = new EstadoCivilPersonal();
            try
            {
                cbxConcepto.DataSource = concepto.listar();
                cbxConcepto.ValueMember = "IdConcepto";
                cbxConcepto.DisplayMember = "Nombre";

                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "Idcategoria";
                cbxCategoria.DisplayMember = "nombre";

                cbxContrato.DataSource = contrato.listar();
                cbxContrato.ValueMember = "Idcontrato";
                cbxContrato.DisplayMember = "Descripcion";

                cbxSeccion.DataSource = seccion.listar();
                cbxSeccion.ValueMember = "Idseccion";
                cbxSeccion.DisplayMember = "Nombre";

                cbxConvenio.DataSource = convenio.listar();
                cbxConvenio.ValueMember = "IDconvenio";
                cbxConvenio.DisplayMember = "Descripcion";

                cbxEstadoCivil.DataSource = estadoCivil.listar();
                cbxEstadoCivil.ValueMember = "IdEstadoCivil";
                cbxEstadoCivil.DisplayMember = "Descripcion";

                cbxConcepto.Text = "";
                cbxCategoria.Text = "";
                cbxContrato.Text = "";
                cbxSeccion.Text = "";
                cbxConvenio.Text = "";
                cbxEstadoCivil.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
            
            //SE INICIA CON EL DIA DE ALTA POSTERIOR AL DE LA CARGA, SI ES FINDE SE CORRE AL LUNES.
            dtpFechaAlta.Value = DateTime.Today.AddDays(1);

            if (dtpFechaAlta.Value.DayOfWeek.ToString() == "Saturday")
            {
                dtpFechaAlta.Value = DateTime.Today.AddDays(3);
            }
            else if (dtpFechaAlta.Value.DayOfWeek.ToString() == "Sunday")
            {
                dtpFechaAlta.Value = DateTime.Today.AddDays(2);
            }


            Conexion conexion;
            try
            {
                conexion = new Conexion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void cargaCBXcontrato()
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
                    consulta = "select IdContrato, descripcion from contrato";
                    comando = new SqlCommand(consulta, conexion);
                    adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }

                cbxContrato.DisplayMember = "descripcion";
                cbxContrato.DataSource = tabla;
                cbxContrato.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoPersonal empleado= new EmpleadoPersonal();
            Empleado nuevo = new Empleado();
            try
            {
                nuevo.FechaAlta = dtpFechaAlta.Value.Date;
                nuevo.IDContrato = Convert.ToInt64(cbxContrato.SelectedValue);
                nuevo.IDSeccion = Convert.ToInt64(cbxSeccion.SelectedValue);
                nuevo.IDConcepto = Convert.ToInt64(cbxConcepto.SelectedValue);
                nuevo.IDConvenio = Convert.ToInt64(cbxConvenio.SelectedValue);
                nuevo.IDCategoria = Convert.ToInt64(cbxCategoria.SelectedValue);
                nuevo.Nombre = txbNombre.Text;
                nuevo.Apellido = txbApellido.Text;
                nuevo.FechaDeNacimiento = dtpFechaNac.Value.Date;
                nuevo.Dni = txbDni.Text;
                nuevo.Cuil = txbCuil.Text;
                nuevo.Nacionalidad = txbNacionalidad.Text;
                nuevo.EstadoCivil = Convert.ToByte(cbxEstadoCivil.SelectedValue);
                nuevo.Hijos = Convert.ToByte(nudHijos.Value.ToString());
                nuevo.Domicilio = txbDomicilio.Text;
                nuevo.Entrecalle1 = txbEntrecalles1.Text;
                nuevo.Entrecalle2 = txbEntrecalles2.Text;
                nuevo.CP = Int64.Parse(txbCP.Text);
                empleado.alta(nuevo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {

            }
        }

        private void cbxContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxConvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

/*
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
*/