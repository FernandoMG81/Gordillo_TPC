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

namespace Presentacion
{
    public partial class frmAltaEquipo : Form
    {
        public frmAltaEquipo()
        {
            InitializeComponent();
            EquipoTelefonoPersonal equipo = new EquipoTelefonoPersonal();
            dgvListaEquipos.DataSource = equipo.Listar();
        }


    }
}
