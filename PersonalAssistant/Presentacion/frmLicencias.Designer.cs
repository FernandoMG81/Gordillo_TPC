namespace Presentacion
{
    partial class frmLicencias
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
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.dgvSeccion = new System.Windows.Forms.DataGridView();
            this.btnAgregarLicencia = new System.Windows.Forms.Button();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txbMotivo = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(206, 41);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(246, 21);
            this.cbEmpleado.TabIndex = 17;
            // 
            // dgvSeccion
            // 
            this.dgvSeccion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccion.Location = new System.Drawing.Point(72, 194);
            this.dgvSeccion.Name = "dgvSeccion";
            this.dgvSeccion.Size = new System.Drawing.Size(584, 244);
            this.dgvSeccion.TabIndex = 16;
            // 
            // btnAgregarLicencia
            // 
            this.btnAgregarLicencia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarLicencia.FlatAppearance.BorderSize = 0;
            this.btnAgregarLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLicencia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarLicencia.Location = new System.Drawing.Point(452, 145);
            this.btnAgregarLicencia.Name = "btnAgregarLicencia";
            this.btnAgregarLicencia.Size = new System.Drawing.Size(89, 21);
            this.btnAgregarLicencia.TabIndex = 15;
            this.btnAgregarLicencia.Text = "AGREGAR";
            this.btnAgregarLicencia.UseVisualStyleBackColor = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(98, 41);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(90, 21);
            this.lblEmpleado.TabIndex = 14;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(123, 74);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(65, 21);
            this.lblMotivo.TabIndex = 18;
            this.lblMotivo.Text = "Motivo";
            // 
            // txbMotivo
            // 
            this.txbMotivo.Location = new System.Drawing.Point(206, 74);
            this.txbMotivo.Name = "txbMotivo";
            this.txbMotivo.Size = new System.Drawing.Size(246, 20);
            this.txbMotivo.TabIndex = 19;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(84, 108);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(104, 21);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(206, 108);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 21;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(206, 143);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 23;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(90, 142);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(98, 21);
            this.lblFechaFinal.TabIndex = 22;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // frmLicencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txbMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.dgvSeccion);
            this.Controls.Add(this.btnAgregarLicencia);
            this.Controls.Add(this.lblEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLicencias";
            this.Text = "frmLicencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.DataGridView dgvSeccion;
        private System.Windows.Forms.Button btnAgregarLicencia;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txbMotivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label lblFechaFinal;
    }
}