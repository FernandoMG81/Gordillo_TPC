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
    public partial class frmMenuPrincipal : frmModelo
    {
        private Usuario usuarioLogueado;

        public Usuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
        }

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }



        private void ptbModuloEmpleados_MouseEnter(object sender, EventArgs e)
        {
            //VER PORQUE SE ROMPE  
            // pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void ptbModuloEmpleados_MouseLeave(object sender, EventArgs e)
        {
            // pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        //QUITAR SI SE CAMBIA LA IMAGEN
        private void lblModuloEmpleado2_MouseEnter(object sender, EventArgs e)
        {
            // pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        //QUITAR SI SE CAMBIA LA IMAGEN
        private void lblModuloEmpleado1_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbConfiguracion_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.ADMINISTRADOR == usuarioLogueado.Tipo.Id)
            {
                frmConfiguracion configuracion = new frmConfiguracion();
                configuracion.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo");

            }
        }

        //QUITAR SI SE CAMBIA LA IMAGEN
        private void lblConfiguracion_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.ADMINISTRADOR == usuarioLogueado.Tipo.Id)
            {
                frmConfiguracion configuracion = new frmConfiguracion();
                configuracion.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo");
            }

        }

        private void ptbModuloEmpleados_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.ADMINISTRADOR == usuarioLogueado.Tipo.Id || TipoUsuario.EMPLEADOS == usuarioLogueado.Tipo.Id)
            {
                frmModuloEmpleados empleados = new frmModuloEmpleados(usuarioLogueado);
                empleados.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo");
            }
        }

        private void lblModuloEmpleado1_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.ADMINISTRADOR == usuarioLogueado.Tipo.Id || TipoUsuario.EMPLEADOS == usuarioLogueado.Tipo.Id)
            {
                frmModuloEmpleados empleados = new frmModuloEmpleados(usuarioLogueado);
                empleados.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo");
            }
        }
        private void lblModuloEmpleado2_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.ADMINISTRADOR == usuarioLogueado.Tipo.Id || TipoUsuario.EMPLEADOS == usuarioLogueado.Tipo.Id)
            {
                frmModuloEmpleados empleados = new frmModuloEmpleados(usuarioLogueado);
                empleados.ShowDialog();
            }

            else
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo");
            }
        }

        private void pbModuloHorarios_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.ADMINISTRADOR == usuarioLogueado.Tipo.Id || TipoUsuario.HORARIO == usuarioLogueado.Tipo.Id)
            {
                frmModuloHorarios moduloHorario = new frmModuloHorarios();
                moduloHorario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo");
            }
        }

        //QUITAR SI SE CAMBIA LA IMAGEN
        private void lblBotonFichajes_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.ADMINISTRADOR == usuarioLogueado.Tipo.Id || TipoUsuario.HORARIO == usuarioLogueado.Tipo.Id)
            {
                frmModuloHorarios moduloHorario = new frmModuloHorarios();
                moduloHorario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo");
            }
        }


        private void frmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            frmLogin login;
            try
            {
                usuarioLogueado = new Usuario();
                login = new frmLogin(usuarioLogueado);
                AddOwnedForm(login);
                login.ShowDialog();
                lblusuarioActivo.Text = usuarioLogueado.Nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Novedad Cumpleanios;
            Novedad PeridodoPrueba;
            Novedad Vacaciones;
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
