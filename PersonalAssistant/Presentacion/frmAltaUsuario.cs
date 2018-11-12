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
    public partial class frmAltaUsuario : Form
    {
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
                nuevo.Nombre = txbUsuario.Text;
                nuevo.Password = encrypt.EncryptKey(txbClave.Text);
                //nuevo.Password = txbClave.Text;
                nuevo.Tipo = new TipoUsuario();
                if (rdbAdmin.Checked) nuevo.Tipo.Id = 1;
                if (rdbPersonal.Checked) nuevo.Tipo.Id = 2;
                if (rdbDeposito.Checked) nuevo.Tipo.Id = 3;
                if (rdbMasculino.Checked) nuevo.Sexo = 'M';
                if (rdbFemenino.Checked) nuevo.Sexo = 'F';
                
               
                usuario.alta(nuevo);
                frmAltaUsuario_Load(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar.Visible = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            UsuariosPersonal equipo = new UsuariosPersonal();
            Usuario baja;

            try
            {

                baja = (Usuario)dgvListaUsuarios.CurrentRow.DataBoundItem;
                equipo.baja(baja);
                frmAltaUsuario_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


    }
}
