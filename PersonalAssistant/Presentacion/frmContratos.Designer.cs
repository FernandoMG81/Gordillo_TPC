namespace Presentacion
{
    partial class frmContratos
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
            this.dgvListaContratos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbContrato = new System.Windows.Forms.TextBox();
            this.lblContratos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaContratos
            // 
            this.dgvListaContratos.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvListaContratos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaContratos.Location = new System.Drawing.Point(57, 170);
            this.dgvListaContratos.Name = "dgvListaContratos";
            this.dgvListaContratos.Size = new System.Drawing.Size(240, 245);
            this.dgvListaContratos.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Location = new System.Drawing.Point(72, 104);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 31);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txbContrato
            // 
            this.txbContrato.Location = new System.Drawing.Point(158, 48);
            this.txbContrato.Name = "txbContrato";
            this.txbContrato.Size = new System.Drawing.Size(156, 20);
            this.txbContrato.TabIndex = 12;
            // 
            // lblContratos
            // 
            this.lblContratos.AutoSize = true;
            this.lblContratos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratos.Location = new System.Drawing.Point(47, 45);
            this.lblContratos.Name = "lblContratos";
            this.lblContratos.Size = new System.Drawing.Size(83, 21);
            this.lblContratos.TabIndex = 11;
            this.lblContratos.Text = "Contrato";
            // 
            // frmContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.dgvListaContratos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbContrato);
            this.Controls.Add(this.lblContratos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContratos";
            this.Text = "frmContratos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaContratos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbContrato;
        private System.Windows.Forms.Label lblContratos;
    }
}