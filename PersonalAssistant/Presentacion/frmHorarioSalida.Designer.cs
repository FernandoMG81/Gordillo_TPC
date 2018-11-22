namespace Presentacion
{
    partial class frmHorarioSalida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorarioSalida));
            this.dgvListaDeposito = new System.Windows.Forms.DataGridView();
            this.btnSalida = new System.Windows.Forms.Button();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSegundos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeposito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDeposito
            // 
            this.dgvListaDeposito.AllowUserToAddRows = false;
            this.dgvListaDeposito.AllowUserToDeleteRows = false;
            this.dgvListaDeposito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListaDeposito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaDeposito.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvListaDeposito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaDeposito.Location = new System.Drawing.Point(47, 76);
            this.dgvListaDeposito.Name = "dgvListaDeposito";
            this.dgvListaDeposito.ReadOnly = true;
            this.dgvListaDeposito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaDeposito.Size = new System.Drawing.Size(296, 335);
            this.dgvListaDeposito.TabIndex = 20;
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalida.Location = new System.Drawing.Point(389, 76);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(213, 31);
            this.btnSalida.TabIndex = 19;
            this.btnSalida.Text = "SALIDA";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.Blue;
            this.lblFecha.Location = new System.Drawing.Point(409, 297);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(178, 17);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Sábado, 20 de Octubre 2018";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.Control;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.lblHora.ForeColor = System.Drawing.Color.Blue;
            this.lblHora.Location = new System.Drawing.Point(415, 218);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(162, 65);
            this.lblHora.TabIndex = 30;
            this.lblHora.Text = "00:00";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.SystemColors.Control;
            this.lblSegundos.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.Blue;
            this.lblSegundos.Location = new System.Drawing.Point(469, 172);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(53, 40);
            this.lblSegundos.TabIndex = 29;
            this.lblSegundos.Text = "00";
            // 
            // cbar
            // 
            this.cbar.animated = false;
            this.cbar.animationIterval = 5;
            this.cbar.animationSpeed = 300;
            this.cbar.BackColor = System.Drawing.SystemColors.Control;
            this.cbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbar.BackgroundImage")));
            this.cbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cbar.ForeColor = System.Drawing.SystemColors.Control;
            this.cbar.LabelVisible = true;
            this.cbar.LineProgressThickness = 8;
            this.cbar.LineThickness = 18;
            this.cbar.Location = new System.Drawing.Point(364, 136);
            this.cbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cbar.MaxValue = 60;
            this.cbar.Name = "cbar";
            this.cbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cbar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cbar.Size = new System.Drawing.Size(262, 262);
            this.cbar.TabIndex = 28;
            this.cbar.Value = 0;
            // 
            // tmr2
            // 
            this.tmr2.Enabled = true;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(119, 41);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(224, 20);
            this.txbApellido.TabIndex = 33;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(44, 42);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 17);
            this.lblApellido.TabIndex = 32;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // frmHorarioSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.cbar);
            this.Controls.Add(this.dgvListaDeposito);
            this.Controls.Add(this.btnSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHorarioSalida";
            this.Text = "frmHorarioSalida";
            this.Load += new System.EventHandler(this.frmHorarioSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeposito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeposito;
        private System.Windows.Forms.Button btnSalida;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHora;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSegundos;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cbar;
        private System.Windows.Forms.Timer tmr2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label lblApellido;
    }
}