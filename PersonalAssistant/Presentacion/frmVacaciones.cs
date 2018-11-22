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
    public partial class frmVacaciones : Form
    {
        private Usuario usuarioLogueado;

        public frmVacaciones(Usuario user)
        {
            InitializeComponent();
            usuarioLogueado = user;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            VacacionesPersonal nuevas = new VacacionesPersonal();
            try
            {
              nuevas.generar(Convert.ToInt16(cbxAnios.SelectedItem),usuarioLogueado);
            }
            catch (SystemException)
            {
                //MessageBox.Show(ex.ToString());

                MessageBox.Show("Todas las vacaciones del año "+ cbxAnios.SelectedItem.ToString() + Environment.NewLine + "ya han sido generadas");
            }
            catch (Exception)
            {
                MessageBox.Show("PRUEBA");
            }
            finally
            {
                cbxAnios_SelectedIndexChanged(sender, e);
            }
        }

        private void frmVacaciones_Load(object sender, EventArgs e)
        {
            for (int i = 2017; i <= DateTime.Now.Year; i++) cbxAnios.Items.Add(i);
        }

        private void cbxAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            VacacionesPersonal vac;

            try
            {
                vac = new VacacionesPersonal();
                dgvVacaciones.DataSource = vac.listar(cbxAnios.SelectedItem.ToString());
                dgvVacaciones.Columns["fecAlta"].Visible = false;
                dgvVacaciones.Columns["fechaInicio"].Visible = false;
                dgvVacaciones.Columns["fechaFinal"].Visible = false;
                dgvVacaciones.Columns["diasVacaciones"].HeaderText = "Resta Vacaciones";
                dgvVacaciones.Columns["diasCalculado"].HeaderText = "Vacaciones del año";
                dgvVacaciones.Columns["anioCalculado"].Visible = false;
                dgvVacaciones.Columns["usuarioCreacion"].HeaderText = "Registrado por";
                dgvVacaciones.Columns["fechaCreacion"].HeaderText = "Fecha";

                dgvVacaciones.CurrentRow.Selected = false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Aún no hay vacaciones generadas para el año " + cbxAnios.SelectedItem.ToString());
            }
        }


        private void btnAsignarVacaciones_Click(object sender, EventArgs e)
        {
            frmAsignarVacaciones asigna;
            try
            {
                asigna = new frmAsignarVacaciones(usuarioLogueado);
                asigna.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
