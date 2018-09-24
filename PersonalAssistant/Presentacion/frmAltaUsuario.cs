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
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            UsuariosPersonal usuarios = new UsuariosPersonal();
            dgvListaUsuarios.DataSource = usuarios.Listar();
        }
    }
}
