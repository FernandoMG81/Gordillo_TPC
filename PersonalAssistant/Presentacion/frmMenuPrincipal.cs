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
        private List<Novedad> listadosNovedad;

        public Usuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
        }

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }



        private void PtbModuloEmpleados_MouseEnter(object sender, EventArgs e)
        {
            //VER PORQUE SE ROMPE  
            // pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PtbModuloEmpleados_MouseLeave(object sender, EventArgs e)
        {
            // pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        //QUITAR SI SE CAMBIA LA IMAGEN
        private void LblModuloEmpleado2_MouseEnter(object sender, EventArgs e)
        {
            // pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        //QUITAR SI SE CAMBIA LA IMAGEN
        private void LblModuloEmpleado1_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PbConfiguracion_Click(object sender, EventArgs e)
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
        private void LblConfiguracion_Click(object sender, EventArgs e)
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

        private void PtbModuloEmpleados_Click(object sender, EventArgs e)
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

        private void LblModuloEmpleado1_Click(object sender, EventArgs e)
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
        private void LblModuloEmpleado2_Click(object sender, EventArgs e)
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

        private void PbModuloHorarios_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.ADMINISTRADOR == usuarioLogueado.Tipo.Id || TipoUsuario.HORARIO == usuarioLogueado.Tipo.Id)
            {
                frmModuloHorarios moduloHorario = new frmModuloHorarios(usuarioLogueado);
                moduloHorario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo");
            }
        }

        //QUITAR SI SE CAMBIA LA IMAGEN
        private void LblBotonFichajes_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.ADMINISTRADOR == usuarioLogueado.Tipo.Id || TipoUsuario.HORARIO == usuarioLogueado.Tipo.Id)
            {
                frmModuloHorarios moduloHorario = new frmModuloHorarios(usuarioLogueado);
                moduloHorario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo");
            }
        }


        private void FrmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            frmLogin login;
            try
            {
                usuarioLogueado = new Usuario();
                login = new frmLogin(usuarioLogueado);
                AddOwnedForm(login);
                login.ShowDialog();
                lblusuarioActivo.Text = usuarioLogueado.Nombre;
                pbxUsuario.Image = Bitmap.FromFile(usuarioLogueado.Imagen);
            }
            catch (ArgumentNullException)
            {
                if (usuarioLogueado.Sexo == 'M') pbxUsuario.Image = Properties.Resources.Masculino;
                else pbxUsuario.Image = Properties.Resources.Femenino;
            }
            catch (ArgumentException)
            {
                if (usuarioLogueado.Sexo == 'M') pbxUsuario.Image = Properties.Resources.Masculino;
                else pbxUsuario.Image = Properties.Resources.Femenino;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Novedad PeridodoPrueba, Cumpleanios,Vacaciones;
          
            NovedadPersonal novedades;
            try
            {
                Cumpleanios = new Novedad();
                PeridodoPrueba = new Novedad();
                Vacaciones = new Novedad();
                novedades = new NovedadPersonal();


                listadosNovedad = novedades.traerCumpleaniosDia();
                lblCumpleDia.Text = "";
                foreach (var item in listadosNovedad)
                {
                    lblCumpleDia.Text += item.NovedadPrincipal + Environment.NewLine;
                }

                listadosNovedad = novedades.traerCumpleaniosMes();
                lblCumpleMes.Text = "";
                foreach (var item in listadosNovedad)
                {
                    lblCumpleMes.Text += item.NovedadPrincipal + Environment.NewLine;
                }

                listadosNovedad = novedades.traerVencimientos();
                lblVencimientos.Text = "";
                foreach (var item in listadosNovedad)
                {
                    lblVencimientos.Text += item.NovedadPrincipal;
                    if (lblVacacionesProximas.Text.Length <= 66)
                    {
                        for (int i = 0; i < (67 - lblVencimientos.Text.Length); i++) lblVencimientos.Text += " ";
                    }
                    lblVencimientos.Text += Environment.NewLine;
                }

                listadosNovedad = novedades.traerVacaciones();
                lblVacacionesProximas .Text = "";
                foreach (var item in listadosNovedad)
                {
                    lblVacacionesProximas.Text += item.NovedadPrincipal;
                    if(lblVacacionesProximas.Text.Length <= 68)
                    {
                        for (int i = 0; i < (69 - lblVacacionesProximas.Text.Length); i++) lblVacacionesProximas.Text += " ";
                    }
                    lblVacacionesProximas.Text += Environment.NewLine;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal_Shown(sender, e);
        }


        private void BtnModificarUsuario_Click(object sender, EventArgs e)
        {
            frmModificarUsuario modi;
            try
            {
                modi = new frmModificarUsuario(usuarioLogueado);
                modi.ShowDialog();
                pbxUsuario.Image = Bitmap.FromFile(usuarioLogueado.Imagen);

            }
            catch (ArgumentNullException)
            {
                if (usuarioLogueado.Sexo == 'M') pbxUsuario.Image = Properties.Resources.Masculino;
                else pbxUsuario.Image = Properties.Resources.Femenino;
            }
            catch (ArgumentException)
            {
                if (usuarioLogueado.Sexo == 'M') pbxUsuario.Image = Properties.Resources.Masculino;
                else pbxUsuario.Image = Properties.Resources.Femenino;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
