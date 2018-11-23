namespace Presentacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblLoginMensaje = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkClave = new System.Windows.Forms.LinkLabel();
            this.btnCerrar2 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblUsuarioMensaje = new System.Windows.Forms.Label();
            this.lblClaveMensaje = new System.Windows.Forms.Label();
            this.lblNoExiste = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 391);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-29, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(249, 135);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(308, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.Silver;
            this.txtClave.Location = new System.Drawing.Point(249, 194);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(308, 20);
            this.txtClave.TabIndex = 2;
            this.txtClave.Text = "CLAVE";
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // lblLoginMensaje
            // 
            this.lblLoginMensaje.AutoSize = true;
            this.lblLoginMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginMensaje.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginMensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoginMensaje.Location = new System.Drawing.Point(357, 46);
            this.lblLoginMensaje.Name = "lblLoginMensaje";
            this.lblLoginMensaje.Size = new System.Drawing.Size(77, 24);
            this.lblLoginMensaje.TabIndex = 3;
            this.lblLoginMensaje.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Location = new System.Drawing.Point(295, 289);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(213, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "INGRESAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkClave
            // 
            this.linkClave.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkClave.AutoSize = true;
            this.linkClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkClave.LinkColor = System.Drawing.Color.White;
            this.linkClave.Location = new System.Drawing.Point(301, 365);
            this.linkClave.Name = "linkClave";
            this.linkClave.Size = new System.Drawing.Size(198, 17);
            this.linkClave.TabIndex = 0;
            this.linkClave.TabStop = true;
            this.linkClave.Text = "¿Ha olvidado la contraseña?";
            this.linkClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClave_LinkClicked);
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar2.Image")));
            this.btnCerrar2.Location = new System.Drawing.Point(550, 0);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(54, 37);
            this.btnCerrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar2.TabIndex = 7;
            this.btnCerrar2.TabStop = false;
            this.btnCerrar2.Visible = false;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            this.btnCerrar2.MouseLeave += new System.EventHandler(this.btnCerrar2_MouseLeave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(550, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(54, 37);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            // 
            // lblUsuarioMensaje
            // 
            this.lblUsuarioMensaje.AutoSize = true;
            this.lblUsuarioMensaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioMensaje.ForeColor = System.Drawing.Color.Lime;
            this.lblUsuarioMensaje.Location = new System.Drawing.Point(249, 162);
            this.lblUsuarioMensaje.Name = "lblUsuarioMensaje";
            this.lblUsuarioMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblUsuarioMensaje.TabIndex = 8;
            // 
            // lblClaveMensaje
            // 
            this.lblClaveMensaje.AutoSize = true;
            this.lblClaveMensaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveMensaje.ForeColor = System.Drawing.Color.Lime;
            this.lblClaveMensaje.Location = new System.Drawing.Point(252, 222);
            this.lblClaveMensaje.Name = "lblClaveMensaje";
            this.lblClaveMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblClaveMensaje.TabIndex = 9;
            // 
            // lblNoExiste
            // 
            this.lblNoExiste.AutoSize = true;
            this.lblNoExiste.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoExiste.ForeColor = System.Drawing.Color.Lime;
            this.lblNoExiste.Location = new System.Drawing.Point(309, 263);
            this.lblNoExiste.Name = "lblNoExiste";
            this.lblNoExiste.Size = new System.Drawing.Size(0, 16);
            this.lblNoExiste.TabIndex = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(600, 391);
            this.Controls.Add(this.lblNoExiste);
            this.Controls.Add(this.lblClaveMensaje);
            this.Controls.Add(this.lblUsuarioMensaje);
            this.Controls.Add(this.btnCerrar2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.linkClave);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLoginMensaje);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblLoginMensaje;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkClave;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnCerrar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioMensaje;
        private System.Windows.Forms.Label lblClaveMensaje;
        private System.Windows.Forms.Label lblNoExiste;
    }
}