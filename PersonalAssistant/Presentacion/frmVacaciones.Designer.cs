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
            this.dgvVacaciones = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbxAnios = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnAsignarVacaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVacaciones
            // 
            this.dgvVacaciones.AllowUserToAddRows = false;
            this.dgvVacaciones.AllowUserToDeleteRows = false;
            this.dgvVacaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVacaciones.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvVacaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacaciones.EnableHeadersVisualStyles = false;
            this.dgvVacaciones.Location = new System.Drawing.Point(66, 117);
            this.dgvVacaciones.MultiSelect = false;
            this.dgvVacaciones.Name = "dgvVacaciones";
            this.dgvVacaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacaciones.Size = new System.Drawing.Size(692, 339);
            this.dgvVacaciones.TabIndex = 25;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerar.Location = new System.Drawing.Point(468, 71);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(172, 21);
            this.btnGenerar.TabIndex = 35;
            this.btnGenerar.Text = "GENERAR VACACIONES";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // cbxAnios
            // 
            this.cbxAnios.FormattingEnabled = true;
            this.cbxAnios.Location = new System.Drawing.Point(301, 71);
            this.cbxAnios.Name = "cbxAnios";
            this.cbxAnios.Size = new System.Drawing.Size(83, 21);
            this.cbxAnios.TabIndex = 40;
            this.cbxAnios.SelectedIndexChanged += new System.EventHandler(this.CbxAnios_SelectedIndexChanged);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(154, 71);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(141, 21);
            this.lblAnio.TabIndex = 41;
            this.lblAnio.Text = "Seleccionar Año ";
            // 
            // btnAsignarVacaciones
            // 
            this.btnAsignarVacaciones.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAsignarVacaciones.FlatAppearance.BorderSize = 0;
            this.btnAsignarVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarVacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarVacaciones.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAsignarVacaciones.Location = new System.Drawing.Point(89, 466);
            this.btnAsignarVacaciones.Name = "btnAsignarVacaciones";
            this.btnAsignarVacaciones.Size = new System.Drawing.Size(172, 21);
            this.btnAsignarVacaciones.TabIndex = 42;
            this.btnAsignarVacaciones.Text = "ASIGNAR VACACIONES";
            this.btnAsignarVacaciones.UseVisualStyleBackColor = false;
            this.btnAsignarVacaciones.Click += new System.EventHandler(this.BtnAsignarVacaciones_Click);
            // 
            // frmVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 499);
            this.Controls.Add(this.btnAsignarVacaciones);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.cbxAnios);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvVacaciones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVacaciones";
            this.Text = "frmVacaciones";
            this.Load += new System.EventHandler(this.frmVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVacaciones;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cbxAnios;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnAsignarVacaciones;
    }
}