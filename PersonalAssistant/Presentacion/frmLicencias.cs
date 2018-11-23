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
    public partial class frmLicencias : Form
    {
        private Usuario usuarioLogueado;

        public frmLicencias(Usuario user)
        {
            InitializeComponent();
            usuarioLogueado = user;
        }

        private void frmLicencias_Load(object sender, EventArgs e)
        {
            EmpleadoPersonal listaActivos;
            Licencia aux;
            LicenciaPersonal lista;
            try
            {
                listaActivos = new EmpleadoPersonal();
                aux = new Licencia();
                lista = new LicenciaPersonal();

                cbEmpleado.DataSource = listaActivos.listar(false);
                cbEmpleado.DisplayMember = "Apellido";
                cbEmpleado.ValueMember = "DNI";
                cbEmpleado.Text = "";

                dgvLicencias.DataSource = lista.listar();

                /*

                                dgvLicencias.DataSource = ListaActivos;
                                dgvLicencias.Columns["baja"].Visible = false;
                                dgvLicencias.Columns["bajaMotivo"].Visible = false;
                                dgvLicencias.Columns["bajaFecha"].Visible = false;
                                dgvLicencias.Columns["idRegistro"].Visible = false;
                                dgvLicencias.Columns["Legajo"].DisplayIndex = 0;
                                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbEmpleado_Format(object sender, ListControlConvertEventArgs e)
        {

            string Nombre = ((Empleado)e.ListItem).Nombre;
            string Apellido = ((Empleado)e.ListItem).Apellido;
            e.Value = Apellido + " " + Nombre;

        }

        private void btnAgregarLicencia_Click(object sender, EventArgs e)
        {
            LicenciaPersonal licencia;
            Licencia nuevo;
            try
            {
                licencia = new LicenciaPersonal();
                nuevo = new Licencia();
                nuevo.DNI = (string)cbEmpleado.SelectedValue;
                nuevo.FechaCreacion = DateTime.Now;
                nuevo.FechaFinal = dtpFechaFinal.Value;
                nuevo.FechaInicio = dtpFechaInicio.Value;
                nuevo.Usuario = new Usuario();
                nuevo.Usuario.ID = usuarioLogueado.ID;
                nuevo.Motivo = txbMotivo.Text;
                licencia.agregar(nuevo);
                frmLicencias_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
