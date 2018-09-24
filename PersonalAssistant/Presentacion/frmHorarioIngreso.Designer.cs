namespace Presentacion
{
    partial class frmHorarioIngreso
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
            this.dgvListaDeposito = new System.Windows.Forms.DataGridView();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnAusente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeposito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDeposito
            // 
            this.dgvListaDeposito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListaDeposito.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvListaDeposito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeposito.Location = new System.Drawing.Point(47, 41);
            this.dgvListaDeposito.Name = "dgvListaDeposito";
            this.dgvListaDeposito.Size = new System.Drawing.Size(293, 370);
            this.dgvListaDeposito.TabIndex = 22;
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIngreso.Location = new System.Drawing.Point(386, 76);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(213, 31);
            this.btnIngreso.TabIndex = 21;
            this.btnIngreso.Text = "INGRESO";
            this.btnIngreso.UseVisualStyleBackColor = false;
            // 
            // btnAusente
            // 
            this.btnAusente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAusente.FlatAppearance.BorderSize = 0;
            this.btnAusente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAusente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAusente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAusente.Location = new System.Drawing.Point(386, 144);
            this.btnAusente.Name = "btnAusente";
            this.btnAusente.Size = new System.Drawing.Size(213, 31);
            this.btnAusente.TabIndex = 23;
            this.btnAusente.Text = "AUSENTE";
            this.btnAusente.UseVisualStyleBackColor = false;
            // 
            // frmHorarioIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.btnAusente);
            this.Controls.Add(this.dgvListaDeposito);
            this.Controls.Add(this.btnIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHorarioIngreso";
            this.Text = "frmHorarioIngreso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeposito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeposito;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnAusente;
    }
}