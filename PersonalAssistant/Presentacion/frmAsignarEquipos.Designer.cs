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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvListaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Location = new System.Drawing.Point(12, 30);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.Size = new System.Drawing.Size(292, 331);
            this.dgvListaEmpleados.TabIndex = 19;
            // 
            // dgvListaEquipos
            // 
            this.dgvListaEquipos.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvListaEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEquipos.Location = new System.Drawing.Point(343, 30);
            this.dgvListaEquipos.Name = "dgvListaEquipos";
            this.dgvListaEquipos.Size = new System.Drawing.Size(292, 331);
            this.dgvListaEquipos.TabIndex = 20;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAsignar.Location = new System.Drawing.Point(343, 367);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(142, 31);
            this.btnAsignar.TabIndex = 21;
            this.btnAsignar.Text = "ASIGNAR";
            this.btnAsignar.UseVisualStyleBackColor = false;
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDesasignar.FlatAppearance.BorderSize = 0;
            this.btnDesasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesasignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesasignar.Location = new System.Drawing.Point(503, 367);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(132, 31);
            this.btnDesasignar.TabIndex = 22;
            this.btnDesasignar.Text = "DESASIGNAR";
            this.btnDesasignar.UseVisualStyleBackColor = false;
            // 
            // frmAsignarEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 449);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.dgvListaEquipos);
            this.Controls.Add(this.dgvListaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsignarEquipos";
            this.Text = "frmAsignarEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private System.Windows.Forms.DataGridView dgvListaEquipos;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnDesasignar;
    }
}