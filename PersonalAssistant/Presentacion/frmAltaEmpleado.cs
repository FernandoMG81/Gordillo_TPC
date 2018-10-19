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

        private Empleado empleado = null;

        public frmAltaEmpleado()
        {
            InitializeComponent();
        }

        public frmAltaEmpleado(Empleado nuevo)
        {
            InitializeComponent();
            empleado = nuevo;
        }

        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {

            ConceptoPersonal concepto = new ConceptoPersonal();
            CategoriaPersonal categoria = new CategoriaPersonal();
            ContratoPersonal contrato = new ContratoPersonal();
            SeccionPersonal seccion = new SeccionPersonal();
            ConvenioPersonal convenio = new ConvenioPersonal();
            EstadoCivilPersonal estadoCivil = new EstadoCivilPersonal();

            LocalidadPersonal localidades = new LocalidadPersonal();
            PartidoPersonal partidos = new PartidoPersonal();
            try
            {
                //txbCP.AutoCompleteSource = localidades.listar();

                cbxConcepto.DataSource = concepto.listar();
                cbxConcepto.ValueMember = "IdConcepto";
                cbxConcepto.DisplayMember = "nombre";

                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "Idcategoria";
                cbxCategoria.DisplayMember = "nombre";

                cbxContrato.DataSource = contrato.listar();
                cbxContrato.ValueMember = "Idcontrato";
                cbxContrato.DisplayMember = "Descripcion";


                cbxSeccion.DataSource = seccion.listar();
                cbxSeccion.ValueMember = "Idseccion";
                cbxSeccion.DisplayMember = "nombre";

                cbxConvenio.DataSource = convenio.listar();
                cbxConvenio.ValueMember = "IDconvenio";
                cbxConvenio.DisplayMember = "Descripcion";

                cbxEstadoCivil.DataSource = estadoCivil.listar();
                cbxEstadoCivil.ValueMember = "IdEstadoCivil";
                cbxEstadoCivil.DisplayMember = "Descripcion";

                cbxLocalidad.DataSource = localidades.listar();
                cbxLocalidad.ValueMember = "Idlocalidad";
                cbxLocalidad.DisplayMember = "nombre";

                cbxPartido.DataSource = partidos.listar();
                cbxPartido.ValueMember = "IDpartido";
                cbxPartido.DisplayMember = "nombre";

                if (empleado!=null)
                {
                    cbxContrato.SelectedItem = empleado.Contrato.Idcontrato;
                    dtpFechaAlta.Value = empleado.FechaAlta;
                    txbNombre.Text = empleado.Nombre;
                    txbApellido.Text = empleado.Apellido;
                    txbDni.Text = empleado.Dni;
                    txbCuil.Text = empleado.Cuil;
                    if (empleado.Sexo == 'M') rdbMasculino.Checked = true;
                    else rdbFemenino.Checked = true;
                    cbxSeccion.SelectedItem = empleado.Seccion.Idseccion;
                    cbxConcepto.SelectedItem = empleado.Concepto.IdConcepto;
                    cbxCategoria.SelectedItem = empleado.Categoria.Idcategoria;
                    cbxConvenio.SelectedItem = empleado.Convenio.IDconvenio;
                    txbObraSocial.Text = empleado.ObraSocial;
                    txbDomicilio.Text = empleado.Domicilio;
                    txbEntrecalles1.Text = empleado.Entrecalle1;
                    txbEntrecalles2.Text = empleado.Entrecalle2;
                    txbCP.Text = empleado.Localidad.cp.ToString();
                    cbxLocalidad.SelectedItem = empleado.Localidad.IDlocalidad;
                    //cbxPartido.SelectedItem = empleado.Localidad.
                    txbTelefonoPrincipal.Text = empleado.TelefonoPrincipal;
                    txbTelefonoAlternativo.Text = empleado.TelefonoSecundario;
                    dtpFechaNac.Value = empleado.FechaDeNacimiento;
                    txbNacionalidad.Text = empleado.Nacionalidad;
                    cbxEstadoCivil.SelectedItem = empleado.EstadoCivil;
                    nudHijos.Value = empleado.Hijos;
                    txbBasico.Text = empleado.Basico.ToString();

                }

                else
                {
          
                    cbxConcepto.Text = "";
                    cbxCategoria.Text = "";
                    cbxContrato.Text = "";
                    cbxSeccion.Text = "";
                    cbxConvenio.Text = "";
                    cbxEstadoCivil.Text = "";
                    cbxLocalidad.Text = "";
                    cbxPartido.Text = "";
                    dtpFechaAlta.Value = DateTime.Today.AddDays(1);

                if (dtpFechaAlta.Value.DayOfWeek.ToString() == "Saturday")
                {
                    dtpFechaAlta.Value = DateTime.Today.AddDays(3);
                }
                else if (dtpFechaAlta.Value.DayOfWeek.ToString() == "Sunday")
                {
                    dtpFechaAlta.Value = DateTime.Today.AddDays(2);
                }
                    }
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
            
            //SE INICIA CON EL DIA DE ALTA POSTERIOR AL DE LA CARGA, SI ES FINDE SE CORRE AL LUNES.

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
                    consulta = "select IdContrato, contrato from contrato";
                    comando = new SqlCommand(consulta, conexion);
                    adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }

                cbxContrato.DisplayMember = "contrato";
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
                nuevo.Contrato = new Contrato();
                nuevo.Contrato.Idcontrato = Convert.ToInt64(cbxContrato.SelectedValue);
                nuevo.Contrato.Descripcion = cbxContrato.DisplayMember;
                nuevo.Sexo = rdbMasculino.Checked ? 'M' : 'F';
                nuevo.Seccion = new Seccion();
                nuevo.Seccion.Idseccion = Convert.ToInt64(cbxSeccion.SelectedValue);
                nuevo.Seccion.Nombre = cbxSeccion.DisplayMember;
                nuevo.Concepto = new Concepto();
                nuevo.Concepto.IdConcepto = Convert.ToInt64(cbxConcepto.SelectedValue);
                nuevo.Concepto.Nombre = cbxConcepto.DisplayMember;
                //nuevo.Concepto.IdArea = cbxSeccion.SelectedItem;
                nuevo.Convenio = new Convenio();
                nuevo.Convenio.IDconvenio = Convert.ToInt64(cbxConvenio.SelectedValue);
                nuevo.Convenio.Descripcion = cbxConvenio.DisplayMember;
                nuevo.Categoria = new Categoria();
                nuevo.Categoria.Idcategoria = Convert.ToInt64(cbxCategoria.SelectedValue);
                nuevo.Categoria.nombre = cbxCategoria.DisplayMember;
                //nuevo.Categoria.IdConcepto = cbxConcepto.SelectedValue;
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
                nuevo.Localidad = new Localidad();
                nuevo.Localidad.cp = Int64.Parse(txbCP.Text);
                nuevo.Localidad.IDlocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                nuevo.Basico = Convert.ToDecimal(txbBasico.Text);
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

        private void cbxLocalidad_Enter(object sender, EventArgs e)
        {
            
        }

        private void txbCP_Validated(object sender, EventArgs e)
        {
            LocalidadPersonal localidades = new LocalidadPersonal();

            if (txbCP.Text == "")
            {
                cbxLocalidad.DataSource = localidades.listar();
                cbxLocalidad.ValueMember = "Idlocalidad";
                cbxLocalidad.DisplayMember = "nombre";
                cbxLocalidad.Text = "";
            }

            else
            {

            cbxLocalidad.DataSource = localidades.listar(Int64.Parse(txbCP.Text));
            cbxLocalidad.ValueMember = "Idlocalidad";
            cbxLocalidad.DisplayMember = "nombre";
            cbxLocalidad.Text = "";

            Int64 ID = Convert.ToInt64(cbxLocalidad.SelectedValue);
            }

            //buscarIDpartido(Convert.ToInt64(cbxLocalidad.SelectedValue));

            PartidoPersonal partidos = new PartidoPersonal();
            cbxPartido.DataSource = partidos.listar();
            cbxPartido.ValueMember = "IDpartido";
            cbxPartido.DisplayMember = "nombre";
            cbxPartido.Text = "";
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