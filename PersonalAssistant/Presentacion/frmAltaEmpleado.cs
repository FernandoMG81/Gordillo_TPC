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


            try
            {

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

                cargarLocalidad();
                cargarPartido();

                if (empleado != null)
                {
                    btnCerrar.Visible = true;
                    cbxContrato.SelectedValue = empleado.Contrato.Idcontrato;
                    dtpFechaAlta.Value = empleado.FechaAlta;
                    txbNombre.Text = empleado.Nombre;
                    txbApellido.Text = empleado.Apellido;
                    txbDni.Text = empleado.Dni;
                    txbCuil.Text = empleado.Cuil;
                    if (empleado.Sexo == 'M') rdbMasculino.Checked = true;
                    else rdbFemenino.Checked = true;
                    cbxSeccion.SelectedValue = empleado.Seccion.Idseccion;
                    cbxConcepto.SelectedValue = empleado.Concepto.IdConcepto;
                    cbxCategoria.SelectedValue = empleado.Categoria.Idcategoria;
                    cbxConvenio.SelectedValue = empleado.Convenio.IDconvenio;
                    txbObraSocial.Text = empleado.ObraSocial;
                    txbDomicilio.Text = empleado.Domicilio;
                    txbEntrecalles1.Text = empleado.Entrecalle1;
                    txbEntrecalles2.Text = empleado.Entrecalle2;
                    txbCP.Text = empleado.Localidad.cp.ToString();
                    cbxLocalidad.SelectedValue = empleado.Localidad.IDlocalidad;
                    cbxPartido.SelectedValue = empleado.Localidad.IDpartido;
                    txbTelefonoPrincipal.Text = empleado.TelefonoPrincipal;
                    txbTelefonoAlternativo.Text = empleado.TelefonoSecundario;
                    dtpFechaNac.Value = empleado.FechaDeNacimiento;
                    txbNacionalidad.Text = empleado.Nacionalidad;
                    cbxEstadoCivil.SelectedValue = empleado.EstadoCivil;
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
            EmpleadoPersonal empleadoPersonal = new EmpleadoPersonal();
            
            try
            {
                if (empleado == null) empleado = new Empleado();

                empleado.FechaAlta = dtpFechaAlta.Value.Date;
                empleado.Contrato = new Contrato();
                empleado.Contrato.Idcontrato = Convert.ToInt64(cbxContrato.SelectedValue);
                empleado.Contrato.Descripcion = cbxContrato.DisplayMember;
                empleado.Sexo = rdbMasculino.Checked ? 'M' : 'F';
                empleado.Seccion = new Seccion();
                empleado.Seccion.Idseccion = Convert.ToInt64(cbxSeccion.SelectedValue);
                empleado.Seccion.Nombre = cbxSeccion.DisplayMember;
                empleado.Concepto = new Concepto();
                empleado.Concepto.IdConcepto = Convert.ToInt64(cbxConcepto.SelectedValue);
                empleado.Concepto.Nombre = cbxConcepto.DisplayMember;
                empleado.Convenio = new Convenio();
                empleado.Convenio.IDconvenio = Convert.ToInt64(cbxConvenio.SelectedValue);
                empleado.Convenio.Descripcion = cbxConvenio.DisplayMember;
                empleado.Categoria = new Categoria();
                empleado.Categoria.Idcategoria = Convert.ToInt64(cbxCategoria.SelectedValue);
                empleado.Categoria.nombre = cbxCategoria.DisplayMember;
                empleado.Nombre = txbNombre.Text;
                empleado.Apellido = txbApellido.Text;
                empleado.FechaDeNacimiento = dtpFechaNac.Value.Date;
                empleado.Dni = txbDni.Text;
                empleado.Cuil = txbCuil.Text;
                empleado.TelefonoPrincipal = txbTelefonoPrincipal.Text;
                empleado.TelefonoSecundario = txbTelefonoAlternativo.Text;
                empleado.Nacionalidad = txbNacionalidad.Text;
                empleado.EstadoCivil = new EstadoCivil();
                empleado.EstadoCivil.IdEstadoCivil = Convert.ToByte(cbxEstadoCivil.SelectedValue);
                empleado.EstadoCivil.Descripcion = cbxEstadoCivil.DisplayMember;
                empleado.Hijos = Convert.ToByte(nudHijos.Value.ToString());
                empleado.Domicilio = txbDomicilio.Text;
                empleado.Entrecalle1 = txbEntrecalles1.Text;
                empleado.Entrecalle2 = txbEntrecalles2.Text;
                empleado.Localidad = new Localidad();
                empleado.Localidad.cp = Int64.Parse(txbCP.Text);
                empleado.Localidad.IDlocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                empleado.Basico = Convert.ToDecimal(txbBasico.Text);

                if (empleado.IDregistro != 0) empleadoPersonal.modificar(empleado);

                else empleadoPersonal.alta(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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


        private void txbCP_Validated(object sender, EventArgs e)
        {
            PartidoPersonal partidos = new PartidoPersonal();

            if (txbCP.Text == "")
            {
                cargarLocalidad();
                cargarPartido();
            }

            else
            {
                LocalidadPersonal aux = new LocalidadPersonal();
                Localidad aux2 = new Localidad();
                cargarLocalidad(Int64.Parse(txbCP.Text));
                Int64 ID = Convert.ToInt64(cbxLocalidad.SelectedValue);
                MessageBox.Show(cbxLocalidad.SelectedValue.ToString());
                aux2 = aux.buscarIDpartido(ID);
                cargarPartido(aux2.IDpartido);              
            }
           
        }


        private void cargarLocalidad(Int64 cp = 0)
        {
            LocalidadPersonal localidades;

            try
            {
                localidades = new LocalidadPersonal();

                if (cp == 0)
                {
                    cbxLocalidad.DataSource = localidades.listar();
                    cbxLocalidad.ValueMember = "IDlocalidad";
                    cbxLocalidad.DisplayMember = "nombre";
                    cbxLocalidad.Text = "";
                }

                else
                {
                    cbxLocalidad.DataSource = localidades.listar(Int64.Parse(txbCP.Text));
                    cbxLocalidad.ValueMember = "IDlocalidad";
                    cbxLocalidad.DisplayMember = "nombre";
                    cbxLocalidad.Text = "";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarPartido(Int64 ID = 0)
        {
            PartidoPersonal partidos;

            try
            {
                partidos = new PartidoPersonal();

                if (ID == 0)
                {
                    cbxPartido.DataSource = partidos.listar();
                    cbxPartido.ValueMember = "IDpartido";
                    cbxPartido.DisplayMember = "nombre";
                    cbxPartido.Text = "";
                }
                else
                {
                    cbxPartido.DataSource = partidos.listar(ID);
                    cbxPartido.ValueMember = "IDpartido";
                    cbxPartido.DisplayMember = "nombre";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxLocalidad_Validating(object sender, CancelEventArgs e)
        {
            LocalidadPersonal aux = new LocalidadPersonal();
            Localidad aux2 = new Localidad();
            Int64 ID = Convert.ToInt64(cbxLocalidad.SelectedValue);
            aux2 = aux.buscarIDpartido(ID);
            txbCP.Text = aux2.cp.ToString();
            cargarPartido(aux2.IDpartido);
        }
    }
}

