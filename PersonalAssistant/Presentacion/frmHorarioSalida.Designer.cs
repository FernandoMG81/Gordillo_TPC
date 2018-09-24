namespace Presentacion
{
    partial class frmHorarioSalida
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
            this.btnSalida = new System.Windows.Forms.Button();
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
            this.dgvListaDeposito.TabIndex = 20;
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalida.Location = new System.Drawing.Point(386, 76);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(213, 31);
            this.btnSalida.TabIndex = 19;
            this.btnSalida.Text = "SALIDA";
            this.btnSalida.UseVisualStyleBackColor = false;
            // 
            // frmHorarioSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.dgvListaDeposito);
            this.Controls.Add(this.btnSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHorarioSalida";
            this.Text = "frmHorarioSalida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeposito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeposito;
        private System.Windows.Forms.Button btnSalida;
    }
}