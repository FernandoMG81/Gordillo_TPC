namespace Presentacion
{
    partial class frmConvenio
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
            this.dgvListaConvenios = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbConvenio = new System.Windows.Forms.TextBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConvenios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaConvenios
            // 
            this.dgvListaConvenios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListaConvenios.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvListaConvenios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaConvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaConvenios.Location = new System.Drawing.Point(57, 170);
            this.dgvListaConvenios.Name = "dgvListaConvenios";
            this.dgvListaConvenios.Size = new System.Drawing.Size(240, 245);
            this.dgvListaConvenios.TabIndex = 18;
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
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txbConvenio
            // 
            this.txbConvenio.Location = new System.Drawing.Point(158, 48);
            this.txbConvenio.Name = "txbConvenio";
            this.txbConvenio.Size = new System.Drawing.Size(156, 20);
            this.txbConvenio.TabIndex = 16;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.Location = new System.Drawing.Point(47, 45);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(86, 21);
            this.lblConvenio.TabIndex = 15;
            this.lblConvenio.Text = "Convenio";
            // 
            // frmConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.dgvListaConvenios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbConvenio);
            this.Controls.Add(this.lblConvenio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConvenio";
            this.Text = "frmConvenio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConvenios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaConvenios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbConvenio;
        private System.Windows.Forms.Label lblConvenio;
    }
}