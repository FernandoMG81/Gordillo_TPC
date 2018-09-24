﻿using System;
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
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
      
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            //VER PORQUE SE ROMPE  
            // pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
           // pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
           // pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbConfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion configuracion = new frmConfiguracion();
            configuracion.ShowDialog();
        }

        private void lblConfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion configuracion = new frmConfiguracion();
            configuracion.ShowDialog();
        }

        private void ptbModuloEmpleados_Click(object sender, EventArgs e)
        {
            frmModuloEmpleados empleados = new frmModuloEmpleados();
            empleados.ShowDialog();
        }

        private void pbModuloHorarios_Click(object sender, EventArgs e)
        {
            frmModuloHorarios moduloHorario = new frmModuloHorarios();
            moduloHorario.ShowDialog();
        }
    }
}
