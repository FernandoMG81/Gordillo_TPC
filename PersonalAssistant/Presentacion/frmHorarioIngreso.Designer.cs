namespace Presentacion
{
    partial class frmHorarioIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorarioIngreso));
            this.dgvListaDeposito = new System.Windows.Forms.DataGridView();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnAusente = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblSegundos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblApellido = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
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
            this.dgvListaDeposito.Location = new System.Drawing.Point(47, 86);
            this.dgvListaDeposito.MultiSelect = false;
            this.dgvListaDeposito.Name = "dgvListaDeposito";
            this.dgvListaDeposito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaDeposito.Size = new System.Drawing.Size(293, 400);
            this.dgvListaDeposito.TabIndex = 22;
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIngreso.Location = new System.Drawing.Point(386, 101);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(213, 31);
            this.btnIngreso.TabIndex = 21;
            this.btnIngreso.Text = "INGRESO";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnAusente
            // 
            this.btnAusente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAusente.FlatAppearance.BorderSize = 0;
            this.btnAusente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAusente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAusente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAusente.Location = new System.Drawing.Point(386, 432);
            this.btnAusente.Name = "btnAusente";
            this.btnAusente.Size = new System.Drawing.Size(213, 31);
            this.btnAusente.TabIndex = 23;
            this.btnAusente.Text = "AUSENTE";
            this.btnAusente.UseVisualStyleBackColor = false;
            this.btnAusente.Click += new System.EventHandler(this.btnAusente_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.cbar.Location = new System.Drawing.Point(359, 156);
            this.cbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cbar.MaxValue = 60;
            this.cbar.Name = "cbar";
            this.cbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cbar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cbar.Size = new System.Drawing.Size(262, 262);
            this.cbar.TabIndex = 24;
            this.cbar.Value = 0;
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.SystemColors.Control;
            this.lblSegundos.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.Blue;
            this.lblSegundos.Location = new System.Drawing.Point(464, 192);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(53, 40);
            this.lblSegundos.TabIndex = 25;
            this.lblSegundos.Text = "00";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.Control;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.lblHora.ForeColor = System.Drawing.Color.Blue;
            this.lblHora.Location = new System.Drawing.Point(410, 238);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(162, 65);
            this.lblHora.TabIndex = 26;
            this.lblHora.Text = "00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.Blue;
            this.lblFecha.Location = new System.Drawing.Point(404, 317);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(178, 17);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Sábado, 20 de Octubre 2018";
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(41, 42);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 17);
            this.lblApellido.TabIndex = 28;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(116, 41);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(224, 20);
            this.txbApellido.TabIndex = 29;
            // 
            // frmHorarioIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 520);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.cbar);
            this.Controls.Add(this.btnAusente);
            this.Controls.Add(this.dgvListaDeposito);
            this.Controls.Add(this.btnIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHorarioIngreso";
            this.Text = "frmHorarioIngreso";
            this.Load += new System.EventHandler(this.frmHorarioIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeposito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeposito;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnAusente;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHora;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSegundos;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cbar;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label lblApellido;
    }
}