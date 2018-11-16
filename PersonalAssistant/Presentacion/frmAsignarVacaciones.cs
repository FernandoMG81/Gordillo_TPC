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
    public partial class frmAsignarVacaciones : frmModelo
    {
        private Usuario usuarioLogueado;
        private bool completo = false;

        public frmAsignarVacaciones(Usuario user)
        {
            InitializeComponent();
            usuarioLogueado = user;
        }

        private void AsignarVacaciones_Load(object sender, EventArgs e)
        {
            VacacionesPersonal lista;
            
            try
            {
                
                for (int i = 2017; i <= DateTime.Now.Year; i++) cbxAnios.Items.Add(i);
                lista = new VacacionesPersonal();            

                dgvVacacionesAsignadas.DataSource = lista.listarVacacionesAsignadas(DateTime.Now.Year);
                dgvVacacionesAsignadas.Columns["diasCalculado"].Visible = false;
                dgvVacacionesAsignadas.Columns["anioCalculado"].Visible = false;
                dgvVacacionesAsignadas.Columns["fecAlta"].Visible = false;
                dgvVacacionesAsignadas.Columns["fechaInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvVacacionesAsignadas.Columns["fechaFinal"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvVacacionesAsignadas.Columns["dni"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxAnios_SelectedIndexChanged(object sender, EventArgs e)
        {

            VacacionesPersonal vacaciones;
            vacaciones = new VacacionesPersonal();
            try
            {
                cbxEmpleado.DataSource = vacaciones.listarEmpleados(cbxAnios.SelectedItem.ToString());
                cbxEmpleado.DisplayMember = "apellido";
                cbxEmpleado.ValueMember = "dni";
                cbxEmpleado.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                completo = true;
            }
        }

        private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (completo)
            {
                VacacionesPersonal dias;
                try
                {                                 
                    dias = new VacacionesPersonal();
                    txbDiasRestantes.Text = dias.traerDiasDisponibles(cbxEmpleado.SelectedValue.ToString(), cbxAnios.SelectedItem.ToString());             
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void cbxEmpleado_Format(object sender, ListControlConvertEventArgs e)
        {
            string Nombre = ((Vacaciones)e.ListItem).Nombre;
            string Apellido = ((Vacaciones)e.ListItem).Apellido;
            e.Value = Apellido + " " + Nombre;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            VacacionesPersonal vacas;
            Vacaciones nuevo;
            VacacionesPersonal lista = new VacacionesPersonal(); ;
            try
            {

                vacas = new VacacionesPersonal();
                nuevo = new Vacaciones();             
                nuevo.dni = (string)cbxEmpleado.SelectedValue;
                nuevo.FechaInicio = dtpFechaInicio.Value;
                nuevo.DiasVacaciones =Convert.ToInt16(txbDiasAsignar.Text);
                nuevo.AnioCalculado = (int)cbxAnios.SelectedItem;
                nuevo.FechaFinal = nuevo.FechaInicio.AddDays(nuevo.DiasVacaciones-1);
                vacas.nuevasVacaciones(nuevo,usuarioLogueado);
            }
            catch (SystemException)
            {
                MessageBox.Show("No pueden asignarse los dias correspondientes, revise los datos ingresados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            finally
            {
                dgvVacacionesAsignadas.DataSource = lista.listarVacacionesAsignadas(DateTime.Now.Year);
                txbDiasAsignar.Text = "";
                cbxEmpleado.Text = "";
            }
        }
    }
}
