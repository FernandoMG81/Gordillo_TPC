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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(287, 141);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 28;
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(287, 107);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(246, 21);
            this.cbEmpleado.TabIndex = 26;
            // 
            // dgvSeccion
            // 
            this.dgvSeccion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccion.Location = new System.Drawing.Point(89, 212);
            this.dgvSeccion.Name = "dgvSeccion";
            this.dgvSeccion.Size = new System.Drawing.Size(643, 244);
            this.dgvSeccion.TabIndex = 25;
            // 
            // btnAgregarLicencia
            // 
            this.btnAgregarLicencia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarLicencia.FlatAppearance.BorderSize = 0;
            this.btnAgregarLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLicencia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarLicencia.Location = new System.Drawing.Point(574, 177);
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
            this.lblFecha.Location = new System.Drawing.Point(166, 141);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(104, 21);
            this.lblFecha.TabIndex = 32;
            this.lblFecha.Text = "Fecha Inicio";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(180, 107);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(90, 21);
            this.lblEmpleado.TabIndex = 30;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(152, 178);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(118, 21);
            this.lblDia.TabIndex = 34;
            this.lblDia.Text = "Dias a asignar";
            // 
            // txbDias
            // 
            this.txbDias.Location = new System.Drawing.Point(287, 178);
            this.txbDias.Name = "txbDias";
            this.txbDias.Size = new System.Drawing.Size(39, 20);
            this.txbDias.TabIndex = 33;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerar.Location = new System.Drawing.Point(329, 41);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(172, 21);
            this.btnGenerar.TabIndex = 35;
            this.btnGenerar.Text = "GENERAR VACACIONES";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Días restantes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(643, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 21);
            this.button1.TabIndex = 38;
            this.button1.Text = "BORRAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(531, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 21);
            this.button2.TabIndex = 39;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerar);
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
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}