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
    public partial class frmModificarEmpleado : Form
    {
        private Usuario usuario;
        public string ComentarioBaja { get; set; }
        public DateTime fechaBaja { get; set; }
        public List<Empleado> ListaActivos { get; set; }
        public List<Empleado> ListaBajas { get; set; }
        public List<Empleado> ListaLegajos { get; set; }

        public frmModificarEmpleado(Usuario user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            EmpleadoPersonal listaActivos, listaBajas, listaLegajos;

            try
            {
                listaActivos = new EmpleadoPersonal();
                listaBajas = new EmpleadoPersonal();
                listaLegajos = new EmpleadoPersonal();
                ListaActivos = (List<Empleado>)listaActivos.listar(false);
                ListaBajas = (List<Empleado>)listaBajas.listar(true);
                ListaLegajos = (List<Empleado>)listaLegajos.listarLegajosPendientes();

                dgvEmpleadosActivos.DataSource = ListaActivos;
                dgvEmpleadosActivos.Columns["baja"].Visible = false;
                dgvEmpleadosActivos.Columns["bajaMotivo"].Visible = false;
                dgvEmpleadosActivos.Columns["bajaFecha"].Visible = false;
                dgvEmpleadosActivos.Columns["idRegistro"].Visible = false;
                dgvEmpleadosActivos.Columns["Legajo"].DisplayIndex = 0;

                dgvEmpleadosBaja.DataSource = ListaBajas;
                dgvEmpleadosBaja.Columns["baja"].Visible = false;
                dgvEmpleadosBaja.Columns["idRegistro"].Visible = false;

                dgvLegajos.DataSource = ListaLegajos;
                dgvLegajos.Columns["idRegistro"].Visible = false;
                dgvLegajos.Columns["Nombre"].ReadOnly = true;
                dgvLegajos.Columns["apellido"].ReadOnly = true;
               // dgvLegajos.Columns["fechaAlta"].HeaderText = "Fecha de alta";
                dgvLegajos.Columns["fechaAlta"].ReadOnly = true;
               // dgvLegajos.Columns["VencimientoPrueba"].HeaderText = "Vencimiento Periodo de Prueba";
                dgvLegajos.Columns["VencimientoPrueba"].ReadOnly = true;
                dgvLegajos.Columns["dni"].ReadOnly = true;
                dgvLegajos.Columns["sexo"].Visible = false;
                dgvLegajos.Columns["contrato"].Visible = false;
                dgvLegajos.Columns["concepto"].Visible = false;
                dgvLegajos.Columns["seccion"].Visible = false;
                dgvLegajos.Columns["convenio"].Visible = false;
                dgvLegajos.Columns["categoria"].Visible = false;
                dgvLegajos.Columns["obraSocial"].Visible = false;
                dgvLegajos.Columns["fechaDeNacimiento"].Visible = false;
                dgvLegajos.Columns["cuil"].Visible = false;
                dgvLegajos.Columns["telefonoPrincipal"].Visible = false;
                dgvLegajos.Columns["telefonoSecundario"].Visible = false;
                dgvLegajos.Columns["nacionalidad"].Visible = false;
                dgvLegajos.Columns["estadoCivil"].Visible = false;
                dgvLegajos.Columns["hijos"].Visible = false;
                dgvLegajos.Columns["domicilio"].Visible = false;
                dgvLegajos.Columns["entreCalle1"].Visible = false;
                dgvLegajos.Columns["entreCalle2"].Visible = false;
                dgvLegajos.Columns["localidad"].Visible = false;
                dgvLegajos.Columns["basico"].Visible = false;
                dgvLegajos.Columns["edad"].Visible = false;
                dgvLegajos.Columns["baja"].Visible = false;
                dgvLegajos.Columns["Apellido"].DisplayIndex = 0;
                dgvLegajos.Columns["nombre"].DisplayIndex = 1;
                dgvLegajos.Columns["TelefonoAsignado"].Visible = false;
                dgvLegajos.Columns["ControlHorario"].Visible = false;
                dgvLegajos.Columns["FechaCreacion"].Visible = false;
                dgvLegajos.Columns["UsuarioCreacion"].Visible = false;
                dgvLegajos.Columns["FechaModificacion"].Visible = false;
                dgvLegajos.Columns["UsuarioModificacion"].Visible = false;
                dgvLegajos.Columns["bajaFecha"].Visible = false;
                dgvLegajos.Columns["bajaMotivo"].Visible = false;
                dgvLegajos.Columns["foto"].Visible = false;
                dgvLegajos.Columns["legajo"].DisplayIndex = 0;
                dgvLegajos.Columns["dni"].DisplayIndex = 1;
                dgvLegajos.Columns["nombre"].DisplayIndex = 2;
                dgvLegajos.Columns["apellido"].DisplayIndex = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EmpleadoPersonal empleado = new EmpleadoPersonal();
            Empleado modificar;

            try
            {

                modificar = (Empleado)dgvEmpleadosActivos.CurrentRow.DataBoundItem;
                //empleado.alta(modificar);
                frmAltaEmpleado modificado = new frmAltaEmpleado(modificar, usuario);
                modificado.ShowDialog();
                frmModificarEmpleado_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            EmpleadoPersonal baja;
            Empleado aux;
            frmComentarioBaja comentario;
            try
            {
                aux = new Empleado();
                baja = new EmpleadoPersonal();
                comentario = new frmComentarioBaja();
                AddOwnedForm(comentario);
                aux = (Empleado)dgvEmpleadosActivos.CurrentRow.DataBoundItem;
                aux.UsuarioModificacion.ID = usuario.ID;
                aux.FechaModificacion = DateTime.Now;
                comentario.ShowDialog();
                aux.BajaFecha = fechaBaja;
                aux.BajaMotivo = ComentarioBaja;
                baja.bajaLogica(aux);
                frmModificarEmpleado_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void tbcListadoEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcListadoEmpleados.SelectedIndex == 0)
            {
                btnBaja.Visible = true;
                btnModificar.Visible = true;
            }
            if (tbcListadoEmpleados.SelectedIndex == 1)
            {
                btnBaja.Visible = false;
                btnModificar.Visible = true;
            }
            if (tbcListadoEmpleados.SelectedIndex == 2)
            {
                btnBaja.Visible = false;
                btnModificar.Visible = false;
            }
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tbcListadoEmpleados.SelectedIndex == 0)
            {
                EmpleadoPersonal listaActivos = new EmpleadoPersonal();

                if (txbBuscar.Text == "")
                {
                    dgvEmpleadosActivos.DataSource = listaActivos.listar(false);
                }
                else
                {
                    if (cbxBuscar.Text == "Apellido")
                    {
                        List<Empleado> lista;
                        lista = ListaActivos.FindAll(LETRA => LETRA.Apellido.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvEmpleadosActivos.DataSource = lista;
                    }
                    else if (cbxBuscar.Text == "Nombre")
                    {
                        List<Empleado> lista;
                        lista = ListaActivos.FindAll(LETRA => LETRA.Nombre.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvEmpleadosActivos.DataSource = lista;
                    }
                }
            }

            if (tbcListadoEmpleados.SelectedIndex == 1)
            {
                EmpleadoPersonal listaBajas = new EmpleadoPersonal();

                if (txbBuscar.Text == "")
                {
                    dgvEmpleadosBaja.DataSource = listaBajas.listar(true);
                }
                else
                {
                    if (cbxBuscar.Text == "Apellido")
                    {
                        List<Empleado> lista;
                        lista = ListaBajas.FindAll(LETRA => LETRA.Apellido.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvEmpleadosBaja.DataSource = lista;
                    }
                    else if (cbxBuscar.Text == "Nombre")
                    {
                        List<Empleado> lista;
                        lista = ListaBajas.FindAll(LETRA => LETRA.Nombre.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvEmpleadosBaja.DataSource = lista;
                    }
                }
            }
            if (tbcListadoEmpleados.SelectedIndex == 2)
            {
                EmpleadoPersonal listaLegajo = new EmpleadoPersonal();

                if (txbBuscar.Text == "")
                {
                    dgvLegajos.DataSource = listaLegajo.listarLegajosPendientes();
                }
                else
                {
                    if (cbxBuscar.Text == "Apellido")
                    {
                        List<Empleado> lista;
                        lista = ListaLegajos.FindAll(LETRA => LETRA.Apellido.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvLegajos.DataSource = lista;
                    }
                    else if (cbxBuscar.Text == "Nombre")
                    {
                        List<Empleado> lista;
                        lista = ListaLegajos.FindAll(LETRA => LETRA.Nombre.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvLegajos.DataSource = lista;
                    }
                }
            }

    
        }

        private void dgvLegajos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            EmpleadoPersonal legajo;
            try
            {
                legajo = new EmpleadoPersonal();
                legajo.modificarLegajo((Empleado)dgvLegajos.CurrentRow.DataBoundItem);
            }
            catch (Exception ex)
            {

                MessageBox.Show("El Número de legajo ya existe");
            }
        }
    }
}
    

