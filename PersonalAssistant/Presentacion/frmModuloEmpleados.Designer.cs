namespace Presentacion
{
    partial class frmModuloEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModuloEmpleados));
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.pnlEmpleados = new System.Windows.Forms.Panel();
            this.btnAsignarEquipo = new System.Windows.Forms.Button();
            this.lblEmpleado2 = new System.Windows.Forms.Label();
            this.lblEmpleados1 = new System.Windows.Forms.Label();
            this.btnListaEmpleados = new System.Windows.Forms.Button();
            this.btnLicencias = new System.Windows.Forms.Button();
            this.btnVacaciones = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAltaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnAltaEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaEmpleado.Image")));
            this.btnAltaEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaEmpleado.Location = new System.Drawing.Point(0, 109);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(145, 32);
            this.btnAltaEmpleado.TabIndex = 0;
            this.btnAltaEmpleado.Text = " Alta Empleado";
            this.btnAltaEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaEmpleado.UseVisualStyleBackColor = true;
            this.btnAltaEmpleado.Click += new System.EventHandler(this.btnAltaEmpleado_Click);
            // 
            // pnlEmpleados
            // 
            this.pnlEmpleados.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlEmpleados.Controls.Add(this.btnAsignarEquipo);
            this.pnlEmpleados.Controls.Add(this.lblEmpleado2);
            this.pnlEmpleados.Controls.Add(this.lblEmpleados1);
            this.pnlEmpleados.Controls.Add(this.btnListaEmpleados);
            this.pnlEmpleados.Controls.Add(this.btnLicencias);
            this.pnlEmpleados.Controls.Add(this.btnVacaciones);
            this.pnlEmpleados.Controls.Add(this.btnAltaEmpleado);
            this.pnlEmpleados.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEmpleados.Location = new System.Drawing.Point(0, 33);
            this.pnlEmpleados.Name = "pnlEmpleados";
            this.pnlEmpleados.Size = new System.Drawing.Size(135, 550);
            this.pnlEmpleados.TabIndex = 2;
            // 
            // btnAsignarEquipo
            // 
            this.btnAsignarEquipo.FlatAppearance.BorderSize = 0;
            this.btnAsignarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnAsignarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarEquipo.Image")));
            this.btnAsignarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarEquipo.Location = new System.Drawing.Point(0, 261);
            this.btnAsignarEquipo.Name = "btnAsignarEquipo";
            this.btnAsignarEquipo.Size = new System.Drawing.Size(145, 32);
            this.btnAsignarEquipo.TabIndex = 9;
            this.btnAsignarEquipo.Text = "  Asignar Equipo";
            this.btnAsignarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsignarEquipo.UseVisualStyleBackColor = true;
            this.btnAsignarEquipo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEmpleado2
            // 
            this.lblEmpleado2.AutoSize = true;
            this.lblEmpleado2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado2.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado2.Location = new System.Drawing.Point(13, 26);
            this.lblEmpleado2.Name = "lblEmpleado2";
            this.lblEmpleado2.Size = new System.Drawing.Size(96, 18);
            this.lblEmpleado2.TabIndex = 8;
            this.lblEmpleado2.Text = "EMPLEADOS";
            // 
            // lblEmpleados1
            // 
            this.lblEmpleados1.AutoSize = true;
            this.lblEmpleados1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados1.ForeColor = System.Drawing.Color.White;
            this.lblEmpleados1.Location = new System.Drawing.Point(14, 7);
            this.lblEmpleados1.Name = "lblEmpleados1";
            this.lblEmpleados1.Size = new System.Drawing.Size(76, 18);
            this.lblEmpleados1.TabIndex = 7;
            this.lblEmpleados1.Text = "MODULO";
            // 
            // btnListaEmpleados
            // 
            this.btnListaEmpleados.FlatAppearance.BorderSize = 0;
            this.btnListaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnListaEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnListaEmpleados.Image")));
            this.btnListaEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaEmpleados.Location = new System.Drawing.Point(0, 147);
            this.btnListaEmpleados.Name = "btnListaEmpleados";
            this.btnListaEmpleados.Size = new System.Drawing.Size(145, 32);
            this.btnListaEmpleados.TabIndex = 6;
            this.btnListaEmpleados.Text = "Lista Empleados";
            this.btnListaEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListaEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaEmpleados.UseVisualStyleBackColor = true;
            this.btnListaEmpleados.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnLicencias
            // 
            this.btnLicencias.FlatAppearance.BorderSize = 0;
            this.btnLicencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicencias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicencias.ForeColor = System.Drawing.Color.White;
            this.btnLicencias.Image = ((System.Drawing.Image)(resources.GetObject("btnLicencias.Image")));
            this.btnLicencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicencias.Location = new System.Drawing.Point(0, 185);
            this.btnLicencias.Name = "btnLicencias";
            this.btnLicencias.Size = new System.Drawing.Size(145, 32);
            this.btnLicencias.TabIndex = 5;
            this.btnLicencias.Text = "  Licencias";
            this.btnLicencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLicencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLicencias.UseVisualStyleBackColor = true;
            this.btnLicencias.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // btnVacaciones
            // 
            this.btnVacaciones.FlatAppearance.BorderSize = 0;
            this.btnVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacaciones.ForeColor = System.Drawing.Color.White;
            this.btnVacaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnVacaciones.Image")));
            this.btnVacaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVacaciones.Location = new System.Drawing.Point(0, 223);
            this.btnVacaciones.Name = "btnVacaciones";
            this.btnVacaciones.Size = new System.Drawing.Size(145, 32);
            this.btnVacaciones.TabIndex = 4;
            this.btnVacaciones.Text = "  Vacaciones";
            this.btnVacaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVacaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVacaciones.UseVisualStyleBackColor = true;
            this.btnVacaciones.Click += new System.EventHandler(this.btnConvenio_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(135, 33);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(892, 550);
            this.pnlContenedor.TabIndex = 3;
            // 
            // frmModuloEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 583);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlEmpleados);
            this.Name = "frmModuloEmpleados";
            this.Text = "frmModuloEmpleados";
            this.Controls.SetChildIndex(this.pnlEmpleados, 0);
            this.Controls.SetChildIndex(this.pnlContenedor, 0);
            this.pnlEmpleados.ResumeLayout(false);
            this.pnlEmpleados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEmpleado;
        private System.Windows.Forms.Panel pnlEmpleados;
        private System.Windows.Forms.Label lblEmpleados1;
        private System.Windows.Forms.Button btnListaEmpleados;
        private System.Windows.Forms.Button btnLicencias;
        private System.Windows.Forms.Button btnVacaciones;
        private System.Windows.Forms.Label lblEmpleado2;
        private System.Windows.Forms.Button btnAsignarEquipo;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}