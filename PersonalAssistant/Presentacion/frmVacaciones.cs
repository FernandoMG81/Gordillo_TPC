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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            nuevas.generar();

        }
    }
}
