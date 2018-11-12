namespace Presentacion
{
    partial class frmCategoria
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
            this.dgvSeccion = new System.Windows.Forms.DataGridView();
            this.btnAgregarSeccion = new System.Windows.Forms.Button();
            this.txbSeccion = new System.Windows.Forms.TextBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.txbConcepto = new System.Windows.Forms.TextBox();
            this.btnAgregarConcepto = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dgvConcepto = new System.Windows.Forms.DataGridView();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.lblTituloSeccion = new System.Windows.Forms.Label();
            this.lblTituloConcepto = new System.Windows.Forms.Label();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.btnBorrarSeccion = new System.Windows.Forms.Button();
            this.btnBorrarConcepto = new System.Windows.Forms.Button();
            this.btnBorrarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeccion
            // 
            this.dgvSeccion.AllowUserToAddRows = false;
            this.dgvSeccion.AllowUserToDeleteRows = false;
            this.dgvSeccion.AllowUserToResizeColumns = false;
            this.dgvSeccion.AllowUserToResizeRows = false;
            this.dgvSeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeccion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSeccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSeccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccion.ColumnHeadersVisible = false;
            this.dgvSeccion.Location = new System.Drawing.Point(18, 170);
            this.dgvSeccion.MultiSelect = false;
            this.dgvSeccion.Name = "dgvSeccion";
            this.dgvSeccion.RowHeadersVisible = false;
            this.dgvSeccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSeccion.Size = new System.Drawing.Size(198, 189);
            this.dgvSeccion.TabIndex = 10;
            this.dgvSeccion.TabStop = false;
            // 
            // btnAgregarSeccion
            // 
            this.btnAgregarSeccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarSeccion.FlatAppearance.BorderSize = 0;
            this.btnAgregarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSeccion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarSeccion.Location = new System.Drawing.Point(513, 26);
            this.btnAgregarSeccion.Name = "btnAgregarSeccion";
            this.btnAgregarSeccion.Size = new System.Drawing.Size(89, 21);
            this.btnAgregarSeccion.TabIndex = 2;
            this.btnAgregarSeccion.Text = "AGREGAR";
            this.btnAgregarSeccion.UseVisualStyleBackColor = false;
            this.btnAgregarSeccion.Click += new System.EventHandler(this.btnAgregarSeccion_Click);
            // 
            // txbSeccion
            // 
            this.txbSeccion.Location = new System.Drawing.Point(348, 27);
            this.txbSeccion.Name = "txbSeccion";
            this.txbSeccion.Size = new System.Drawing.Size(144, 20);
            this.txbSeccion.TabIndex = 1;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(44, 26);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(71, 21);
            this.lblSeccion.TabIndex = 7;
            this.lblSeccion.Text = "Seccion";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(44, 62);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(91, 21);
            this.lblConcepto.TabIndex = 11;
            this.lblConcepto.Text = "Concepto";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(44, 101);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 21);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbSeccion
            // 
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(152, 25);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(161, 21);
            this.cbSeccion.TabIndex = 0;
            this.cbSeccion.SelectedIndexChanged += new System.EventHandler(this.cbSeccion_SelectedIndexChanged);
            // 
            // cbConcepto
            // 
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(152, 65);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(161, 21);
            this.cbConcepto.TabIndex = 3;
            this.cbConcepto.SelectedIndexChanged += new System.EventHandler(this.cbConcepto_SelectedIndexChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(152, 104);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(161, 21);
            this.cbCategoria.TabIndex = 6;
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(348, 105);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(144, 20);
            this.txbCategoria.TabIndex = 7;
            // 
            // txbConcepto
            // 
            this.txbConcepto.Location = new System.Drawing.Point(348, 66);
            this.txbConcepto.Name = "txbConcepto";
            this.txbConcepto.Size = new System.Drawing.Size(144, 20);
            this.txbConcepto.TabIndex = 4;
            // 
            // btnAgregarConcepto
            // 
            this.btnAgregarConcepto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarConcepto.FlatAppearance.BorderSize = 0;
            this.btnAgregarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarConcepto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarConcepto.Location = new System.Drawing.Point(513, 66);
            this.btnAgregarConcepto.Name = "btnAgregarConcepto";
            this.btnAgregarConcepto.Size = new System.Drawing.Size(89, 21);
            this.btnAgregarConcepto.TabIndex = 5;
            this.btnAgregarConcepto.Text = "AGREGAR";
            this.btnAgregarConcepto.UseVisualStyleBackColor = false;
            this.btnAgregarConcepto.Click += new System.EventHandler(this.btnAgregarConcepto_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(513, 105);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(89, 21);
            this.btnAgregarCategoria.TabIndex = 8;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // dgvConcepto
            // 
            this.dgvConcepto.AllowUserToAddRows = false;
            this.dgvConcepto.AllowUserToDeleteRows = false;
            this.dgvConcepto.AllowUserToResizeColumns = false;
            this.dgvConcepto.AllowUserToResizeRows = false;
            this.dgvConcepto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConcepto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConcepto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConcepto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvConcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcepto.ColumnHeadersVisible = false;
            this.dgvConcepto.Location = new System.Drawing.Point(226, 170);
            this.dgvConcepto.MultiSelect = false;
            this.dgvConcepto.Name = "dgvConcepto";
            this.dgvConcepto.RowHeadersVisible = false;
            this.dgvConcepto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConcepto.Size = new System.Drawing.Size(198, 189);
            this.dgvConcepto.TabIndex = 20;
            this.dgvConcepto.TabStop = false;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToResizeColumns = false;
            this.dgvCategoria.AllowUserToResizeRows = false;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.ColumnHeadersVisible = false;
            this.dgvCategoria.Location = new System.Drawing.Point(434, 171);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCategoria.Size = new System.Drawing.Size(198, 189);
            this.dgvCategoria.TabIndex = 21;
            this.dgvCategoria.TabStop = false;
            // 
            // lblTituloSeccion
            // 
            this.lblTituloSeccion.AutoSize = true;
            this.lblTituloSeccion.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSeccion.Location = new System.Drawing.Point(80, 146);
            this.lblTituloSeccion.Name = "lblTituloSeccion";
            this.lblTituloSeccion.Size = new System.Drawing.Size(72, 21);
            this.lblTituloSeccion.TabIndex = 22;
            this.lblTituloSeccion.Text = "Seccion";
            // 
            // lblTituloConcepto
            // 
            this.lblTituloConcepto.AutoSize = true;
            this.lblTituloConcepto.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConcepto.Location = new System.Drawing.Point(280, 146);
            this.lblTituloConcepto.Name = "lblTituloConcepto";
            this.lblTituloConcepto.Size = new System.Drawing.Size(88, 21);
            this.lblTituloConcepto.TabIndex = 23;
            this.lblTituloConcepto.Text = "Concepto";
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(487, 146);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(89, 21);
            this.lblTituloCategoria.TabIndex = 24;
            this.lblTituloCategoria.Text = "Categoria";
            // 
            // btnBorrarSeccion
            // 
            this.btnBorrarSeccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBorrarSeccion.FlatAppearance.BorderSize = 0;
            this.btnBorrarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarSeccion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBorrarSeccion.Location = new System.Drawing.Point(48, 365);
            this.btnBorrarSeccion.Name = "btnBorrarSeccion";
            this.btnBorrarSeccion.Size = new System.Drawing.Size(135, 21);
            this.btnBorrarSeccion.TabIndex = 25;
            this.btnBorrarSeccion.Text = "BORRAR SECCION";
            this.btnBorrarSeccion.UseVisualStyleBackColor = false;
            this.btnBorrarSeccion.Click += new System.EventHandler(this.btnBorrarSeccion_Click);
            // 
            // btnBorrarConcepto
            // 
            this.btnBorrarConcepto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBorrarConcepto.FlatAppearance.BorderSize = 0;
            this.btnBorrarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarConcepto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBorrarConcepto.Location = new System.Drawing.Point(258, 365);
            this.btnBorrarConcepto.Name = "btnBorrarConcepto";
            this.btnBorrarConcepto.Size = new System.Drawing.Size(135, 21);
            this.btnBorrarConcepto.TabIndex = 26;
            this.btnBorrarConcepto.Text = "BORRAR CONCEPTO";
            this.btnBorrarConcepto.UseVisualStyleBackColor = false;
            this.btnBorrarConcepto.Click += new System.EventHandler(this.btnBorrarConcepto_Click);
            // 
            // btnBorrarCategoria
            // 
            this.btnBorrarCategoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBorrarCategoria.FlatAppearance.BorderSize = 0;
            this.btnBorrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCategoria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBorrarCategoria.Location = new System.Drawing.Point(467, 366);
            this.btnBorrarCategoria.Name = "btnBorrarCategoria";
            this.btnBorrarCategoria.Size = new System.Drawing.Size(135, 21);
            this.btnBorrarCategoria.TabIndex = 27;
            this.btnBorrarCategoria.Text = "BORRAR CATEGORIA";
            this.btnBorrarCategoria.UseVisualStyleBackColor = false;
            this.btnBorrarCategoria.Click += new System.EventHandler(this.btnBorrarCategoria_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 415);
            this.Controls.Add(this.btnBorrarCategoria);
            this.Controls.Add(this.btnBorrarConcepto);
            this.Controls.Add(this.btnBorrarSeccion);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.lblTituloConcepto);
            this.Controls.Add(this.lblTituloSeccion);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.dgvConcepto);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnAgregarConcepto);
            this.Controls.Add(this.txbConcepto);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbConcepto);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.dgvSeccion);
            this.Controls.Add(this.btnAgregarSeccion);
            this.Controls.Add(this.txbSeccion);
            this.Controls.Add(this.lblSeccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeccion;
        private System.Windows.Forms.Button btnAgregarSeccion;
        private System.Windows.Forms.TextBox txbSeccion;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.ComboBox cbConcepto;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.TextBox txbConcepto;
        private System.Windows.Forms.Button btnAgregarConcepto;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dgvConcepto;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Label lblTituloSeccion;
        private System.Windows.Forms.Label lblTituloConcepto;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.Button btnBorrarSeccion;
        private System.Windows.Forms.Button btnBorrarConcepto;
        private System.Windows.Forms.Button btnBorrarCategoria;
    }
}