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

        private bool completo = false;

        public frmAsignarVacaciones()
        {
            InitializeComponent();

        }

        private void AsignarVacaciones_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 2016; i <= DateTime.Now.Year; i++) cbxAnios.Items.Add(i);

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
    }
}
