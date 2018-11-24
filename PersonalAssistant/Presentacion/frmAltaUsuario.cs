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
    public partial class frmAltaUsuario : Form
    {
        private Usuario usuarioActivo = null;

        protected override void OnShown(EventArgs e)
        {
            dgvListaUsuarios.ClearSelection();
            base.OnShown(e);
        }


        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            btnBorrar.Visible = false;
            UsuariosPersonal usuarios = new UsuariosPersonal();
            try
            {
                dgvListaUsuarios.DataSource = usuarios.Listar();
                dgvListaUsuarios.Columns["id"].Visible = false;
                dgvListaUsuarios.Columns["password"].Visible = false;
                dgvListaUsuarios.Columns["tipo"].Visible = false;
                dgvListaUsuarios.Columns["sexo"].Visible = false;
                dgvListaUsuarios.Columns["imagen"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txbUsuario.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuariosPersonal usuario = new UsuariosPersonal();
            Usuario nuevo = new Usuario();
            Encrypt encrypt = new Encrypt();
            //CHequeos
            try
            {
                if (usuarioActivo == null) usuarioActivo = new Usuario();
                usuarioActivo.Nombre = txbUsuario.Text;
                usuarioActivo.Password = encrypt.EncryptKey(txbClave.Text);
                usuarioActivo.Mail = txbMail.Text;
                usuarioActivo.Imagen = txbDireccionFoto.Text;
                usuarioActivo.Tipo = new TipoUsuario();
                if (rdbAdmin.Checked) usuarioActivo.Tipo.Id = 1;
                if (rdbPersonal.Checked) usuarioActivo.Tipo.Id = 2;
                if (rdbDeposito.Checked) usuarioActivo.Tipo.Id = 3;
                if (rdbMasculino.Checked) usuarioActivo.Sexo = 'M';
                if (rdbFemenino.Checked) usuarioActivo.Sexo = 'F';
                if (txbDireccionFoto.Text != "")
                {
                    string destino = Path.Combine(Application.StartupPath, string.Format("c:\\PRUEBA\\{0}", Path.GetFileName(txbDireccionFoto.Text))); //TODO: Cambiar al directorio real de las fotos
                    if (txbDireccionFoto.Text != destino) File.Copy(txbDireccionFoto.Text, destino);
                    usuarioActivo.Imagen = destino;
                }


                if (usuarioActivo.ID == 0) usuario.alta(usuarioActivo);
                else usuario.modificar(usuarioActivo);

                //GUARDA LA IMAGEN CARGADA TODO: CAMBIAR LA DIRECCION A LA CARPETA CORRESPONDIENTE EN EL SERVIDOR
                limpiar();
                frmAltaUsuario_Load(sender, e);

            }
            catch (Exception)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre");
            }
        }

        private void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar.Visible = true;
            txbUsuario.Enabled = false;
            
            UsuariosPersonal usuario;
            Encrypt encripta;
            try
            {
                usuario = new UsuariosPersonal();
                encripta = new Encrypt();
                usuarioActivo = (Usuario)dgvListaUsuarios.CurrentRow.DataBoundItem;
                usuarioActivo = usuario.llenarUsuario(usuarioActivo.Nombre);
                txbUsuario.Text = usuarioActivo.Nombre;
                txbClave.Text = encripta.DecryptKey(usuarioActivo.Password);
                txbMail.Text = usuarioActivo.Mail;
                txbDireccionFoto.Text = usuarioActivo.Imagen;
                if (usuarioActivo.Sexo == 'M')
                {
                    rdbMasculino.Checked = true;
                    pbxAvatar.Image = Properties.Resources.Masculino;
                }
                else
                {
                    rdbFemenino.Checked = true;
                    pbxAvatar.Image = Properties.Resources.Femenino;
                }
                if (txbDireccionFoto.Text != "") pbxAvatar.Image = Bitmap.FromFile(usuarioActivo.Imagen);
                if (usuarioActivo.Tipo.Id == 1) rdbAdmin.Checked = true;
                else if (usuarioActivo.Tipo.Id == 2) rdbPersonal.Checked = true;
                else rdbDeposito.Checked = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            UsuariosPersonal equipo = new UsuariosPersonal();
            Usuario baja;

            try
            {
                baja = (Usuario)dgvListaUsuarios.CurrentRow.DataBoundItem;
                equipo.baja(baja);
                usuarioActivo = null;
                limpiar();
                frmAltaUsuario_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void limpiar()
        {
            txbUsuario.Text = "";
            txbClave.Text = "";
            txbDireccionFoto.Text = "";
            txbMail.Text = "";
            rdbAdmin.Checked = false;
            rdbDeposito.Checked = false;
            rdbFemenino.Checked = false;
            rdbMasculino.Checked = false;
            rdbPersonal.Checked = false;
        }

        private void btnCargarAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF(*.gif)|*.gif";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pbxAvatar.ImageLocation = file.FileName;
                txbDireccionFoto.Text = file.FileName;
            }

        }
    }
}
