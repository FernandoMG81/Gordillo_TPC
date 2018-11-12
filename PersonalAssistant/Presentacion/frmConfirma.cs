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
    public partial class frmConfirma : Form
    {
        private string mensaje;
        private bool confirma = false;

        public bool Confirma
        {
            get { return confirma; }
        }

        public frmConfirma(string mensaje)
        {
            InitializeComponent();
            this.mensaje = mensaje;
        }

        private void frmConfirma_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = mensaje;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            confirma = true;
            Dispose();
        }
    }
}
