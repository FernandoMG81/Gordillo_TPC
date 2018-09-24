namespace Presentacion
{
    partial class frmVacaciones
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.dgvSeccion = new System.Windows.Forms.DataGridView();
            this.btnAgregarLicencia = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.txbDias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(242, 61);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 28;
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(242, 27);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(246, 21);
            this.cbEmpleado.TabIndex = 26;
            // 
            // dgvSeccion
            // 
            this.dgvSeccion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccion.Location = new System.Drawing.Point(81, 147);
            this.dgvSeccion.Name = "dgvSeccion";
            this.dgvSeccion.Size = new System.Drawing.Size(570, 215);
            this.dgvSeccion.TabIndex = 25;
            // 
            // btnAgregarLicencia
            // 
            this.btnAgregarLicencia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarLicencia.FlatAppearance.BorderSize = 0;
            this.btnAgregarLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLicencia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarLicencia.Location = new System.Drawing.Point(529, 97);
            this.btnAgregarLicencia.Name = "btnAgregarLicencia";
            this.btnAgregarLicencia.Size = new System.Drawing.Size(89, 21);
            this.btnAgregarLicencia.TabIndex = 24;
            this.btnAgregarLicencia.Text = "AGREGAR";
            this.btnAgregarLicencia.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(121, 61);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(104, 21);
            this.lblFecha.TabIndex = 32;
            this.lblFecha.Text = "Fecha Inicio";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(135, 27);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(90, 21);
            this.lblEmpleado.TabIndex = 30;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(160, 98);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(42, 21);
            this.lblDia.TabIndex = 34;
            this.lblDia.Text = "Dias";
            // 
            // txbDias
            // 
            this.txbDias.Location = new System.Drawing.Point(242, 98);
            this.txbDias.Name = "txbDias";
            this.txbDias.Size = new System.Drawing.Size(39, 20);
            this.txbDias.TabIndex = 33;
            // 
            // frmVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 396);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txbDias);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.dgvSeccion);
            this.Controls.Add(this.btnAgregarLicencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVacaciones";
            this.Text = "frmVacaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.DataGridView dgvSeccion;
        private System.Windows.Forms.Button btnAgregarLicencia;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txbDias;
    }
}