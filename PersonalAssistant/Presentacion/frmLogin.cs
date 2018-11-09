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
    public partial class frmLogin : Form
    {
        private Usuario usuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(Usuario Usuario)
        {
            InitializeComponent();
            usuario = Usuario;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "CLAVE")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.DimGray;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "CLAVE";
                txtClave.ForeColor = Color.Silver;
                txtClave.UseSystemPasswordChar = false;
            }
        }


        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.Visible = false;
            btnCerrar2.Visible = true;
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar2_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar2.Visible = false;
            btnCerrar.Visible = true;
        }
    }
}
