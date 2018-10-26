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

namespace Presentacion
{
    
    public partial class frmComentario : Form
    {
        public frmComentario()
        {
            InitializeComponent();
        }


        
        private void btnOK_Click(object sender, EventArgs e)
        {
            frmAsignarEquipos Principal = Owner as frmAsignarEquipos;
            Principal.Comentario = rtxComentario.Text;
            this.Dispose();
        }
    }
}