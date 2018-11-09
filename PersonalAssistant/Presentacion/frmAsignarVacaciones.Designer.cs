namespace Presentacion
{
    partial class frmAsignarVacaciones
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
            this.txbDiasRestantes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.txbDiasAsignar = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dgvSeccion = new System.Windows.Forms.DataGridView();
            this.lblAnio = new System.Windows.Forms.Label();
            this.cbxAnios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDiasRestantes
            // 
            this.txbDiasRestantes.Location = new System.Drawing.Point(484, 151);
            this.txbDiasRestantes.Name = "txbDiasRestantes";
            this.txbDiasRestantes.ReadOnly = true;
            this.txbDiasRestantes.Size = new System.Drawing.Size(39, 20);
            this.txbDiasRestantes.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Días restantes";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(152, 150);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(118, 21);
            this.lblDia.TabIndex = 43;
            this.lblDia.Text = "Dias a asignar";
            // 
            // txbDiasAsignar
            // 
            this.txbDiasAsignar.Location = new System.Drawing.Point(287, 150);
            this.txbDiasAsignar.Name = "txbDiasAsignar";
            this.txbDiasAsignar.Size = new System.Drawing.Size(39, 20);
            this.txbDiasAsignar.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(166, 113);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(104, 21);
            this.lblFecha.TabIndex = 41;
            this.lblFecha.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(287, 113);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 2;
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(287, 79);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(246, 21);
            this.cbxEmpleado.TabIndex = 1;
            this.cbxEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbxEmpleado_SelectedIndexChanged);
            this.cbxEmpleado.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbxEmpleado_Format);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(180, 79);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(90, 21);
            this.lblEmpleado.TabIndex = 40;
            this.lblEmpleado.Text = "Empleado";
            // 
            // dgvSeccion
            // 
            this.dgvSeccion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccion.Location = new System.Drawing.Point(44, 190);
            this.dgvSeccion.Name = "dgvSeccion";
            this.dgvSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeccion.Size = new System.Drawing.Size(643, 338);
            this.dgvSeccion.TabIndex = 46;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(129, 45);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(141, 21);
            this.lblAnio.TabIndex = 48;
            this.lblAnio.Text = "Seleccionar Año ";
            // 
            // cbxAnios
            // 
            this.cbxAnios.FormattingEnabled = true;
            this.cbxAnios.Location = new System.Drawing.Point(287, 48);
            this.cbxAnios.Name = "cbxAnios";
            this.cbxAnios.Size = new System.Drawing.Size(83, 21);
            this.cbxAnios.TabIndex = 0;
            this.cbxAnios.SelectedIndexChanged += new System.EventHandler(this.cbxAnios_SelectedIndexChanged);
            // 
            // frmAsignarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 541);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.cbxAnios);
            this.Controls.Add(this.dgvSeccion);
            this.Controls.Add(this.txbDiasRestantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txbDiasAsignar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbxEmpleado);
            this.Name = "frmAsignarVacaciones";
            this.Text = "AsignarVacaciones";
            this.Load += new System.EventHandler(this.AsignarVacaciones_Load);
            this.Controls.SetChildIndex(this.cbxEmpleado, 0);
            this.Controls.SetChildIndex(this.dtpFechaInicio, 0);
            this.Controls.SetChildIndex(this.lblEmpleado, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.txbDiasAsignar, 0);
            this.Controls.SetChildIndex(this.lblDia, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txbDiasRestantes, 0);
            this.Controls.SetChildIndex(this.dgvSeccion, 0);
            this.Controls.SetChildIndex(this.cbxAnios, 0);
            this.Controls.SetChildIndex(this.lblAnio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDiasRestantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txbDiasAsignar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cbxEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.DataGridView dgvSeccion;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.ComboBox cbxAnios;
    }
}