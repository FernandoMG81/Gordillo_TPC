namespace Presentacion
{
    partial class frmAltaUsuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.gbTipoUsuario = new System.Windows.Forms.GroupBox();
            this.rdbDeposito = new System.Windows.Forms.RadioButton();
            this.rdbPersonal = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.btnCargarAvatar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.gbTipoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.gbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(71, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 21);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clave";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(152, 32);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(156, 20);
            this.txbUsuario.TabIndex = 0;
            // 
            // txbClave
            // 
            this.txbClave.Location = new System.Drawing.Point(152, 64);
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '*';
            this.txbClave.Size = new System.Drawing.Size(156, 20);
            this.txbClave.TabIndex = 1;
            // 
            // gbTipoUsuario
            // 
            this.gbTipoUsuario.Controls.Add(this.rdbDeposito);
            this.gbTipoUsuario.Controls.Add(this.rdbPersonal);
            this.gbTipoUsuario.Controls.Add(this.rdbAdmin);
            this.gbTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoUsuario.Location = new System.Drawing.Point(60, 174);
            this.gbTipoUsuario.Name = "gbTipoUsuario";
            this.gbTipoUsuario.Size = new System.Drawing.Size(421, 54);
            this.gbTipoUsuario.TabIndex = 4;
            this.gbTipoUsuario.TabStop = false;
            this.gbTipoUsuario.Text = "Tipo de Usuario";
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDeposito.Location = new System.Drawing.Point(287, 25);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(126, 21);
            this.rdbDeposito.TabIndex = 4;
            this.rdbDeposito.TabStop = true;
            this.rdbDeposito.Text = "Control Horario";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            // 
            // rdbPersonal
            // 
            this.rdbPersonal.AutoSize = true;
            this.rdbPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPersonal.Location = new System.Drawing.Point(130, 25);
            this.rdbPersonal.Name = "rdbPersonal";
            this.rdbPersonal.Size = new System.Drawing.Size(151, 21);
            this.rdbPersonal.TabIndex = 4;
            this.rdbPersonal.TabStop = true;
            this.rdbPersonal.Text = "Modulo Empleados";
            this.rdbPersonal.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdmin.Location = new System.Drawing.Point(8, 25);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(116, 21);
            this.rdbAdmin.TabIndex = 4;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(159, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(213, 31);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.AllowUserToAddRows = false;
            this.dgvListaUsuarios.AllowUserToDeleteRows = false;
            this.dgvListaUsuarios.AllowUserToResizeRows = false;
            this.dgvListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(48, 271);
            this.dgvListaUsuarios.MultiSelect = false;
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.ReadOnly = true;
            this.dgvListaUsuarios.RowHeadersVisible = false;
            this.dgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(438, 142);
            this.dgvListaUsuarios.TabIndex = 6;
            this.dgvListaUsuarios.TabStop = false;
            this.dgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuarios_CellClick);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rdbFemenino);
            this.gbSexo.Controls.Add(this.rdbMasculino);
            this.gbSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(60, 121);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(191, 37);
            this.gbSexo.TabIndex = 3;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(99, 14);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(89, 21);
            this.rdbFemenino.TabIndex = 3;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(8, 14);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(90, 21);
            this.rdbMasculino.TabIndex = 3;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAvatar.Image = global::Presentacion.Properties.Resources.Masculino;
            this.pbxAvatar.Location = new System.Drawing.Point(386, 32);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(100, 100);
            this.pbxAvatar.TabIndex = 8;
            this.pbxAvatar.TabStop = false;
            // 
            // btnCargarAvatar
            // 
            this.btnCargarAvatar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCargarAvatar.FlatAppearance.BorderSize = 0;
            this.btnCargarAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAvatar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarAvatar.Location = new System.Drawing.Point(381, 146);
            this.btnCargarAvatar.Name = "btnCargarAvatar";
            this.btnCargarAvatar.Size = new System.Drawing.Size(111, 28);
            this.btnCargarAvatar.TabIndex = 5;
            this.btnCargarAvatar.Text = "Subir Imagen";
            this.btnCargarAvatar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBorrar.Location = new System.Drawing.Point(492, 296);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(130, 31);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(152, 97);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(156, 20);
            this.txbMail.TabIndex = 2;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(20, 94);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(117, 21);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail recupero";
            // 
            // frmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 431);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargarAvatar);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.dgvListaUsuarios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbTipoUsuario);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaUsuario";
            this.Text = "frmAltaUsuario";
            this.Load += new System.EventHandler(this.frmAltaUsuario_Load);
            this.gbTipoUsuario.ResumeLayout(false);
            this.gbTipoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.GroupBox gbTipoUsuario;
        private System.Windows.Forms.RadioButton rdbDeposito;
        private System.Windows.Forms.RadioButton rdbPersonal;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Button btnCargarAvatar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.Label lblMail;
    }
}