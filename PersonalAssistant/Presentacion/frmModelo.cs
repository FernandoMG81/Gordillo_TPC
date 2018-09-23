using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class frmModelo : Form
    {
        public frmModelo()
        {
            InitializeComponent();
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg, int wparam, int lparam);

        private void ptbMinimizarSelect_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptmRestaurarSelect_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbRestaurar.Visible = false;
            ptbMaximizar.Visible = true;
            ptbRestaurarSelect.Visible = false;
        }

        private void ptbMaximizarSelect_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbMaximizar.Visible = false;
            ptbRestaurar.Visible = true;
            ptbMaximizarSelect.Visible = false;
        }

        private void ptbCerrarSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            ptbMinimizar.Visible = false;
            ptbMinimizarSelect.Visible = true;
        }

        private void ptbMinimizarSelect_MouseLeave(object sender, EventArgs e)
        {
            ptbMinimizarSelect.Visible = false;
            ptbMinimizar.Visible = true;
        }

        private void ptbRestaurar_MouseEnter(object sender, EventArgs e)
        {
            ptbRestaurar.Visible = false;
            ptbRestaurarSelect.Visible = true;
        }

        private void ptbMaximizar_MouseEnter(object sender, EventArgs e)
        {
            ptbMaximizar.Visible = false;
            ptbMaximizarSelect.Visible = true;
        }

        private void ptbMaximizarSelect_MouseLeave(object sender, EventArgs e)
        {
            ptbMaximizarSelect.Visible = false;
            if(this.WindowState==FormWindowState.Normal)
            ptbMaximizar.Visible = true;
        }

        private void pbxCerrarM_MouseEnter(object sender, EventArgs e)
        {
            ptbCerrarM.Visible = false;
            ptbCerrarSelect.Visible = true;
        }

        private void ptbRestaurarSelect_MouseLeave(object sender, EventArgs e)
        {
            ptbRestaurarSelect.Visible = false;
            if(this.WindowState==FormWindowState.Maximized)
            ptbRestaurar.Visible = true;
        }

        private void ptbCerrarSelect_MouseLeave(object sender, EventArgs e)
        {
            ptbCerrarSelect.Visible = false;
            ptbCerrarM.Visible = true;
        }

        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
