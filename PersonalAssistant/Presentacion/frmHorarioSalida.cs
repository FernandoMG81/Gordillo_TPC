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
    public partial class frmHorarioSalida : Form
    {
        public frmHorarioSalida()
        {
            InitializeComponent();
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            lblSegundos.Text = DateTime.Now.ToString("ss");
            cbar.Value = Convert.ToInt32(DateTime.Now.ToString("ss"));
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void frmHorarioSalida_Load(object sender, EventArgs e)
        {
            EmpleadoPersonal empleados;
            horarioPersonal horario;
            try
            {
                horario = new horarioPersonal();
                empleados = new EmpleadoPersonal();
                dgvListaDeposito.DataSource = horario.listarSalida();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
