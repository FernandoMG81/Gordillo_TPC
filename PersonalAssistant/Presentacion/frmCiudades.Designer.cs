namespace Presentacion
{
    partial class frmCiudades
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
            this.btnAgregarPartido = new System.Windows.Forms.Button();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.txbLocalidad = new System.Windows.Forms.TextBox();
            this.txbPartido = new System.Windows.Forms.TextBox();
            this.cbPartido = new System.Windows.Forms.ComboBox();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbCP = new System.Windows.Forms.ComboBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.dgvPartido = new System.Windows.Forms.DataGridView();
            this.btnAgregarCP = new System.Windows.Forms.Button();
            this.txbCP = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPartido
            // 
            this.btnAgregarPartido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarPartido.FlatAppearance.BorderSize = 0;
            this.btnAgregarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPartido.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarPartido.Location = new System.Drawing.Point(539, 139);
            this.btnAgregarPartido.Name = "btnAgregarPartido";
            this.btnAgregarPartido.Size = new System.Drawing.Size(89, 21);
            this.btnAgregarPartido.TabIndex = 32;
            this.btnAgregarPartido.Text = "AGREGAR";
            this.btnAgregarPartido.UseVisualStyleBackColor = false;
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarLocalidad.FlatAppearance.BorderSize = 0;
            this.btnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLocalidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(539, 100);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(89, 21);
            this.btnAgregarLocalidad.TabIndex = 31;
            this.btnAgregarLocalidad.Text = "AGREGAR";
            this.btnAgregarLocalidad.UseVisualStyleBackColor = false;
            // 
            // txbLocalidad
            // 
            this.txbLocalidad.Location = new System.Drawing.Point(374, 100);
            this.txbLocalidad.Name = "txbLocalidad";
            this.txbLocalidad.Size = new System.Drawing.Size(144, 20);
            this.txbLocalidad.TabIndex = 30;
            // 
            // txbPartido
            // 
            this.txbPartido.Location = new System.Drawing.Point(374, 139);
            this.txbPartido.Name = "txbPartido";
            this.txbPartido.Size = new System.Drawing.Size(144, 20);
            this.txbPartido.TabIndex = 29;
            // 
            // cbPartido
            // 
            this.cbPartido.FormattingEnabled = true;
            this.cbPartido.Location = new System.Drawing.Point(178, 138);
            this.cbPartido.Name = "cbPartido";
            this.cbPartido.Size = new System.Drawing.Size(161, 21);
            this.cbPartido.TabIndex = 28;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(178, 99);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(161, 21);
            this.cbLocalidad.TabIndex = 27;
            // 
            // cbCP
            // 
            this.cbCP.FormattingEnabled = true;
            this.cbCP.Location = new System.Drawing.Point(178, 59);
            this.cbCP.Name = "cbCP";
            this.cbCP.Size = new System.Drawing.Size(161, 21);
            this.cbCP.TabIndex = 26;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.Location = new System.Drawing.Point(106, 135);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(66, 21);
            this.lblPartido.TabIndex = 25;
            this.lblPartido.Text = "Partido";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(85, 96);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(87, 21);
            this.lblLocalidad.TabIndex = 24;
            this.lblLocalidad.Text = "Localidad";
            // 
            // dgvPartido
            // 
            this.dgvPartido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPartido.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvPartido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPartido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartido.Location = new System.Drawing.Point(154, 206);
            this.dgvPartido.Name = "dgvPartido";
            this.dgvPartido.Size = new System.Drawing.Size(395, 189);
            this.dgvPartido.TabIndex = 23;
            // 
            // btnAgregarCP
            // 
            this.btnAgregarCP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarCP.FlatAppearance.BorderSize = 0;
            this.btnAgregarCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarCP.Location = new System.Drawing.Point(539, 60);
            this.btnAgregarCP.Name = "btnAgregarCP";
            this.btnAgregarCP.Size = new System.Drawing.Size(89, 21);
            this.btnAgregarCP.TabIndex = 22;
            this.btnAgregarCP.Text = "AGREGAR";
            this.btnAgregarCP.UseVisualStyleBackColor = false;
            // 
            // txbCP
            // 
            this.txbCP.Location = new System.Drawing.Point(374, 61);
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(144, 20);
            this.txbCP.TabIndex = 21;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(55, 60);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(118, 21);
            this.lblCP.TabIndex = 20;
            this.lblCP.Text = "Codigo Postal";
            // 
            // frmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.btnAgregarPartido);
            this.Controls.Add(this.btnAgregarLocalidad);
            this.Controls.Add(this.txbLocalidad);
            this.Controls.Add(this.txbPartido);
            this.Controls.Add(this.cbPartido);
            this.Controls.Add(this.cbLocalidad);
            this.Controls.Add(this.cbCP);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.dgvPartido);
            this.Controls.Add(this.btnAgregarCP);
            this.Controls.Add(this.txbCP);
            this.Controls.Add(this.lblCP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCiudades";
            this.Text = "frmCiudades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPartido;
        private System.Windows.Forms.Button btnAgregarLocalidad;
        private System.Windows.Forms.TextBox txbLocalidad;
        private System.Windows.Forms.TextBox txbPartido;
        private System.Windows.Forms.ComboBox cbPartido;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.ComboBox cbCP;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.DataGridView dgvPartido;
        private System.Windows.Forms.Button btnAgregarCP;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.Label lblCP;
    }
}