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
        public frmModificarEmpleado()
        {
            InitializeComponent();
        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            EmpleadoPersonal lista;
            try
            {
                lista = new EmpleadoPersonal();
                dgvEmpleados.DataSource = lista.listar();
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

                modificar = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                //empleado.alta(modificar);
                frmAltaEmpleado modificado = new frmAltaEmpleado(modificar);
                modificado.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
