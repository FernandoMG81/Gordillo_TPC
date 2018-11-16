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
using System.Security.Cryptography;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuariosPersonal usuarioNegocio = new UsuariosPersonal();
            Encrypt encripta = new Encrypt();
            try
            {
                usuario.Nombre = txtUsuario.Text;
                usuario.Password = encripta.EncryptKey(txtClave.Text);
                if (usuarioNegocio.validarUsuario(usuario))
                {
                    usuario = usuarioNegocio.llenarUsuario(usuario.Nombre);
                    frmMenuPrincipal principal = Owner as frmMenuPrincipal;
                    principal.UsuarioLogueado.ID = usuario.ID;
                    principal.UsuarioLogueado.Nombre = usuario.Nombre;
                    principal.UsuarioLogueado.Password = usuario.Password;
                    principal.UsuarioLogueado.Sexo = usuario.Sexo;
                    principal.UsuarioLogueado.Tipo.Id = usuario.Tipo.Id;
                    principal.UsuarioLogueado.Tipo.Descripcion = usuario.Tipo.Descripcion;

                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario o password incorrectos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) //Presionar enter en cualquier momento y activar el boton de login
            {
                btnLogin_Click(sender, e);
            }

            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;

        }

        private void linkClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "" || txtUsuario.Text == "USUARIO")
                {
                    errorProvider1.SetError(txtUsuario, "Debe escribir un nombre de usuario");
                }
                else
                {
                    MailPersonal mail = new MailPersonal();
                    mail.enviarCorreo(txtUsuario.Text.ToLower());
                }

            }
            catch (Exception)
            {

                MessageBox.Show("El usuario no se encuentra en el sistema");
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
            errorProvider1.Dispose();
        }
    }
}
