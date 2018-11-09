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
        public frmVacaciones()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            VacacionesPersonal nuevas = new VacacionesPersonal();
            try
            {
              nuevas.generar();
            }
            catch (SystemException)
            {
                MessageBox.Show("Todas las vacaciones del año "+ cbxAnios.SelectedItem.ToString() + Environment.NewLine + "ya han sido generadas");
            }
            catch (Exception)
            {
                MessageBox.Show("PRUEBA");
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
                dgvVacaciones.Columns["AnioCalculado"].Visible = false;
                dgvVacaciones.Columns["diasCalculado"].Visible = false;
                dgvVacaciones.Columns["diasVacaciones"].HeaderText = "Vacaciones";
                dgvVacaciones.CurrentRow.Selected = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Aún no hay vacaciones generadas para el año " + cbxAnios.SelectedItem.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAsignarVacaciones asigna;
            try
            {
                asigna = new frmAsignarVacaciones();
                asigna.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
