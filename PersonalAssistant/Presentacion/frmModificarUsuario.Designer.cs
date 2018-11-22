namespace Presentacion
{
    partial class frmModificarUsuario
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
            this.txbMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnCargarAvatar = new System.Windows.Forms.Button();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtClaveNueva = new System.Windows.Forms.TextBox();
            this.lblClaveNueva = new System.Windows.Forms.Label();
            this.lblClaveAnterior = new System.Windows.Forms.Label();
            this.txtClaveAnterior = new System.Windows.Forms.TextBox();
            this.txbDireccionImagen = new System.Windows.Forms.TextBox();
            this.txbDireccionCopia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(163, 286);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(156, 20);
            this.txbMail.TabIndex = 14;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(45, 285);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(117, 21);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "Mail recupero";
            // 
            // btnCargarAvatar
            // 
            this.btnCargarAvatar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCargarAvatar.FlatAppearance.BorderSize = 0;
            this.btnCargarAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAvatar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarAvatar.Location = new System.Drawing.Point(135, 169);
            this.btnCargarAvatar.Name = "btnCargarAvatar";
            this.btnCargarAvatar.Size = new System.Drawing.Size(111, 28);
            this.btnCargarAvatar.TabIndex = 15;
            this.btnCargarAvatar.Text = "Cambiar Imagen";
            this.btnCargarAvatar.UseVisualStyleBackColor = false;
            this.btnCargarAvatar.Click += new System.EventHandler(this.btnCargarAvatar_Click);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAvatar.Image = global::Presentacion.Properties.Resources.Masculino;
            this.pbxAvatar.Location = new System.Drawing.Point(140, 55);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(100, 100);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar.TabIndex = 17;
            this.pbxAvatar.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(79, 357);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(213, 31);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Location = new System.Drawing.Point(163, 249);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.PasswordChar = '*';
            this.txtClaveNueva.Size = new System.Drawing.Size(156, 20);
            this.txtClaveNueva.TabIndex = 12;
            // 
            // lblClaveNueva
            // 
            this.lblClaveNueva.AutoSize = true;
            this.lblClaveNueva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveNueva.Location = new System.Drawing.Point(48, 248);
            this.lblClaveNueva.Name = "lblClaveNueva";
            this.lblClaveNueva.Size = new System.Drawing.Size(114, 21);
            this.lblClaveNueva.TabIndex = 13;
            this.lblClaveNueva.Text = "Clave Nueva";
            // 
            // lblClaveAnterior
            // 
            this.lblClaveAnterior.AutoSize = true;
            this.lblClaveAnterior.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveAnterior.Location = new System.Drawing.Point(38, 211);
            this.lblClaveAnterior.Name = "lblClaveAnterior";
            this.lblClaveAnterior.Size = new System.Drawing.Size(124, 21);
            this.lblClaveAnterior.TabIndex = 13;
            this.lblClaveAnterior.Text = "Clave Anterior";
            // 
            // txtClaveAnterior
            // 
            this.txtClaveAnterior.Location = new System.Drawing.Point(163, 212);
            this.txtClaveAnterior.Name = "txtClaveAnterior";
            this.txtClaveAnterior.PasswordChar = '*';
            this.txtClaveAnterior.Size = new System.Drawing.Size(156, 20);
            this.txtClaveAnterior.TabIndex = 12;
            // 
            // txbDireccionImagen
            // 
            this.txbDireccionImagen.Location = new System.Drawing.Point(272, 169);
            this.txbDireccionImagen.Name = "txbDireccionImagen";
            this.txbDireccionImagen.Size = new System.Drawing.Size(76, 20);
            this.txbDireccionImagen.TabIndex = 19;
            // 
            // txbDireccionCopia
            // 
            this.txbDireccionCopia.Location = new System.Drawing.Point(272, 135);
            this.txbDireccionCopia.Name = "txbDireccionCopia";
            this.txbDireccionCopia.Size = new System.Drawing.Size(76, 20);
            this.txbDireccionCopia.TabIndex = 20;
            // 
            // frmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 433);
            this.Controls.Add(this.txbDireccionCopia);
            this.Controls.Add(this.txbDireccionImagen);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnCargarAvatar);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveAnterior);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.lblClaveAnterior);
            this.Controls.Add(this.lblClaveNueva);
            this.Name = "frmModificarUsuario";
            this.Text = "frmModificarUsuario";
            this.Load += new System.EventHandler(this.frmModificarUsuario_Load);
            this.Controls.SetChildIndex(this.lblClaveNueva, 0);
            this.Controls.SetChildIndex(this.lblClaveAnterior, 0);
            this.Controls.SetChildIndex(this.txtClaveNueva, 0);
            this.Controls.SetChildIndex(this.txtClaveAnterior, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.pbxAvatar, 0);
            this.Controls.SetChildIndex(this.btnCargarAvatar, 0);
            this.Controls.SetChildIndex(this.lblMail, 0);
            this.Controls.SetChildIndex(this.txbMail, 0);
            this.Controls.SetChildIndex(this.txbDireccionImagen, 0);
            this.Controls.SetChildIndex(this.txbDireccionCopia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnCargarAvatar;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtClaveNueva;
        private System.Windows.Forms.Label lblClaveNueva;
        private System.Windows.Forms.Label lblClaveAnterior;
        private System.Windows.Forms.TextBox txtClaveAnterior;
        private System.Windows.Forms.TextBox txbDireccionImagen;
        private System.Windows.Forms.TextBox txbDireccionCopia;
    }
}