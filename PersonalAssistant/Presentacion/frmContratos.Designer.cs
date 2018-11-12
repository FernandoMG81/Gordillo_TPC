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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbContrato = new System.Windows.Forms.TextBox();
            this.lblContratos = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvListaConvenios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConvenios)).BeginInit();
            this.SuspendLayout();
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbContrato
            // 
            this.txbContrato.Location = new System.Drawing.Point(158, 48);
            this.txbContrato.Name = "txbContrato";
            this.txbContrato.Size = new System.Drawing.Size(156, 20);
            this.txbContrato.TabIndex = 12;
            this.txbContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContrato_KeyPress);
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
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBorrar.Location = new System.Drawing.Point(75, 367);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(213, 31);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvListaConvenios
            // 
            this.dgvListaConvenios.AllowUserToResizeColumns = false;
            this.dgvListaConvenios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListaConvenios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaConvenios.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvListaConvenios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaConvenios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListaConvenios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaConvenios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListaConvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaConvenios.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListaConvenios.Location = new System.Drawing.Point(87, 141);
            this.dgvListaConvenios.MultiSelect = false;
            this.dgvListaConvenios.Name = "dgvListaConvenios";
            this.dgvListaConvenios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaConvenios.RowHeadersVisible = false;
            this.dgvListaConvenios.Size = new System.Drawing.Size(188, 220);
            this.dgvListaConvenios.TabIndex = 20;
            // 
            // frmContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvListaConvenios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbContrato);
            this.Controls.Add(this.lblContratos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContratos";
            this.Text = "frmContratos";
            this.Load += new System.EventHandler(this.frmContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConvenios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbContrato;
        private System.Windows.Forms.Label lblContratos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dgvListaConvenios;
    }
}