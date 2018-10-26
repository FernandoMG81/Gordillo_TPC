namespace Presentacion
{
    partial class frmAsignarEquipos
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
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvListaEquipos = new System.Windows.Forms.DataGridView();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvAsignados = new System.Windows.Forms.DataGridView();
            this.lblListadoEmpleadoEquipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvListaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Location = new System.Drawing.Point(12, 88);
            this.dgvListaEmpleados.MultiSelect = false;
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.ReadOnly = true;
            this.dgvListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(292, 201);
            this.dgvListaEmpleados.TabIndex = 19;
            // 
            // dgvListaEquipos
            // 
            this.dgvListaEquipos.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvListaEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEquipos.Location = new System.Drawing.Point(328, 88);
            this.dgvListaEquipos.MultiSelect = false;
            this.dgvListaEquipos.Name = "dgvListaEquipos";
            this.dgvListaEquipos.ReadOnly = true;
            this.dgvListaEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEquipos.Size = new System.Drawing.Size(513, 201);
            this.dgvListaEquipos.TabIndex = 20;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAsignar.Location = new System.Drawing.Point(419, 38);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(142, 31);
            this.btnAsignar.TabIndex = 21;
            this.btnAsignar.Text = "ASIGNAR";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDesasignar.FlatAppearance.BorderSize = 0;
            this.btnDesasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesasignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesasignar.Location = new System.Drawing.Point(12, 516);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(132, 31);
            this.btnDesasignar.TabIndex = 22;
            this.btnDesasignar.Text = "DESASIGNAR";
            this.btnDesasignar.UseVisualStyleBackColor = false;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(108, 38);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(196, 20);
            this.txbBuscar.TabIndex = 23;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblBuscar.Location = new System.Drawing.Point(28, 37);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(74, 21);
            this.lblBuscar.TabIndex = 24;
            this.lblBuscar.Text = "BUSCAR";
            // 
            // dgvAsignados
            // 
            this.dgvAsignados.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvAsignados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignados.Location = new System.Drawing.Point(12, 335);
            this.dgvAsignados.MultiSelect = false;
            this.dgvAsignados.Name = "dgvAsignados";
            this.dgvAsignados.ReadOnly = true;
            this.dgvAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignados.Size = new System.Drawing.Size(829, 175);
            this.dgvAsignados.TabIndex = 25;
            // 
            // lblListadoEmpleadoEquipo
            // 
            this.lblListadoEmpleadoEquipo.AutoSize = true;
            this.lblListadoEmpleadoEquipo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblListadoEmpleadoEquipo.Location = new System.Drawing.Point(12, 311);
            this.lblListadoEmpleadoEquipo.Name = "lblListadoEmpleadoEquipo";
            this.lblListadoEmpleadoEquipo.Size = new System.Drawing.Size(291, 21);
            this.lblListadoEmpleadoEquipo.TabIndex = 26;
            this.lblListadoEmpleadoEquipo.Text = "LISTADO DE EMPLEADOS Y EQUIPOS";
            // 
            // frmAsignarEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 569);
            this.Controls.Add(this.lblListadoEmpleadoEquipo);
            this.Controls.Add(this.dgvAsignados);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.dgvListaEquipos);
            this.Controls.Add(this.dgvListaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsignarEquipos";
            this.Text = "frmAsignarEquipos";
            this.Load += new System.EventHandler(this.frmAsignarEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private System.Windows.Forms.DataGridView dgvListaEquipos;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvAsignados;
        private System.Windows.Forms.Label lblListadoEmpleadoEquipo;
    }
}