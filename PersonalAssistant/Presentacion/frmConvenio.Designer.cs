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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaConvenios = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbConvenio = new System.Windows.Forms.TextBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConvenios)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaConvenios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaConvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaConvenios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaConvenios.Location = new System.Drawing.Point(84, 149);
            this.dgvListaConvenios.MultiSelect = false;
            this.dgvListaConvenios.Name = "dgvListaConvenios";
            this.dgvListaConvenios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaConvenios.RowHeadersVisible = false;
            this.dgvListaConvenios.Size = new System.Drawing.Size(188, 220);
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbConvenio
            // 
            this.txbConvenio.Location = new System.Drawing.Point(158, 48);
            this.txbConvenio.Name = "txbConvenio";
            this.txbConvenio.Size = new System.Drawing.Size(156, 20);
            this.txbConvenio.TabIndex = 16;
            this.txbConvenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbConvenio_KeyPress);
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
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBorrar.Location = new System.Drawing.Point(72, 375);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(213, 31);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvListaConvenios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbConvenio);
            this.Controls.Add(this.lblConvenio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConvenio";
            this.Text = "frmConvenio";
            this.Load += new System.EventHandler(this.frmConvenio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConvenios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaConvenios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbConvenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.Button btnBorrar;
    }
}