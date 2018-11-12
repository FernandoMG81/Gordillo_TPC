using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmComentarioBaja : Form
    {
        public frmComentarioBaja()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado Principal = Owner as frmModificarEmpleado;
            Principal.ComentarioBaja = rtxComentario.Text;
            Principal.fechaBaja = dtpBaja.Value;
            this.Dispose();
        }
    }
}
