using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmCorrecto : Form
    {
        public frmCorrecto()
        {
            InitializeComponent();
        }

        private void frmCorrecto_Load(object sender, EventArgs ev)
        {

            timer1.Interval = 5500;
            timer1.Start();
            timer1.Tick += (s, e) => {
                this.Close();
            };
        }
    }
}
