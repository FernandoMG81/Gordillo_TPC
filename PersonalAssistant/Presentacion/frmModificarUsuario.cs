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
using System.IO;

namespace Presentacion
{
    public partial class frmModificarUsuario : frmModelo
    {
        private Usuario usuarioLogueado;
        public frmModificarUsuario(Usuario user)
        {
            InitializeComponent();
            usuarioLogueado = user;
        }

        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {

            try
            {
                txbMail.Text = usuarioLogueado.Mail;
                txbDireccionImagen.Text = usuarioLogueado.Imagen;
                txbDireccionCopia.Text = usuarioLogueado.Imagen;
                pbxAvatar.Image = Bitmap.FromFile(usuarioLogueado.Imagen);
            }
            catch (ArgumentNullException)
            {
                if (usuarioLogueado.Sexo == 'M') pbxAvatar.Image = Properties.Resources.Masculino;
                else pbxAvatar.Image = Properties.Resources.Femenino;
            }
            catch (ArgumentException)
            {
                if (usuarioLogueado.Sexo == 'M') pbxAvatar.Image = Properties.Resources.Masculino;
                else pbxAvatar.Image = Properties.Resources.Femenino;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCargarAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png |GIF (*.gif)|*.gif";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pbxAvatar.ImageLocation = file.FileName;
                txbDireccionImagen.Text = file.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuariosPersonal user;
            Encrypt encripta;
            try
            {
                if (txtClaveAnterior.Text == "" && txtClaveNueva.Text == "")
                {
                    user = new UsuariosPersonal();
                    encripta = new Encrypt();
                    usuarioLogueado.Mail = txbMail.Text;
                    if (txbDireccionCopia.Text != txbDireccionImagen.Text && txbDireccionCopia.Text != "")
                    {
                        //File.Delete(txbDireccionCopia.Text);
                    }
                    string destino = Path.Combine(Application.StartupPath, string.Format("c:\\PRUEBA\\{0}", Path.GetFileName(txbDireccionImagen.Text))); //TODO: Cambiar al directorio real de las fotos
                    File.Copy(txbDireccionImagen.Text, destino);
                    usuarioLogueado.Imagen = destino;
                    user.modificarImagenMail(usuarioLogueado);
                }
                else
                {
                    user = new UsuariosPersonal();
                    encripta = new Encrypt();
                    usuarioLogueado.Password = encripta.EncryptKey(txtClaveAnterior.Text);
                    if (user.validarUsuario(usuarioLogueado))
                    {
                        usuarioLogueado.Password = txtClaveNueva.Text;
                        usuarioLogueado.Mail = txbMail.Text;
                        if (txbDireccionCopia.Text != txbDireccionImagen.Text && txbDireccionCopia.Text != "")
                        {
                            //File.Delete(txbDireccionCopia.Text);
                        }
                        string destino = Path.Combine(Application.StartupPath, string.Format("c:\\PRUEBA\\{0}", Path.GetFileName(txbDireccionImagen.Text))); //TODO: Cambiar al directorio real de las fotos
                        File.Copy(txbDireccionImagen.Text, destino);
                        usuarioLogueado.Password = encripta.EncryptKey(txtClaveNueva.Text);
                        usuarioLogueado.Imagen = destino;
                        user.modificar(usuarioLogueado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
