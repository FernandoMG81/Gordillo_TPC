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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeccion
            // 
            this.dgvSeccion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccion.Location = new System.Drawing.Point(18, 170);
            this.dgvSeccion.Name = "dgvSeccion";
            this.dgvSeccion.Size = new System.Drawing.Size(198, 189);
            this.dgvSeccion.TabIndex = 10;
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
            this.btnAgregarSeccion.TabIndex = 9;
            this.btnAgregarSeccion.Text = "AGREGAR";
            this.btnAgregarSeccion.UseVisualStyleBackColor = false;
            // 
            // txbSeccion
            // 
            this.txbSeccion.Location = new System.Drawing.Point(348, 27);
            this.txbSeccion.Name = "txbSeccion";
            this.txbSeccion.Size = new System.Drawing.Size(144, 20);
            this.txbSeccion.TabIndex = 8;
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
            this.cbSeccion.TabIndex = 13;
            // 
            // cbConcepto
            // 
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(152, 65);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(161, 21);
            this.cbConcepto.TabIndex = 14;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(152, 104);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(161, 21);
            this.cbCategoria.TabIndex = 15;
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(348, 105);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(144, 20);
            this.txbCategoria.TabIndex = 16;
            // 
            // txbConcepto
            // 
            this.txbConcepto.Location = new System.Drawing.Point(348, 66);
            this.txbConcepto.Name = "txbConcepto";
            this.txbConcepto.Size = new System.Drawing.Size(144, 20);
            this.txbConcepto.TabIndex = 17;
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
            this.btnAgregarConcepto.TabIndex = 18;
            this.btnAgregarConcepto.Text = "AGREGAR";
            this.btnAgregarConcepto.UseVisualStyleBackColor = false;
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
            this.btnAgregarCategoria.TabIndex = 19;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            // 
            // dgvConcepto
            // 
            this.dgvConcepto.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvConcepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcepto.Location = new System.Drawing.Point(226, 170);
            this.dgvConcepto.Name = "dgvConcepto";
            this.dgvConcepto.Size = new System.Drawing.Size(198, 189);
            this.dgvConcepto.TabIndex = 20;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(434, 171);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(198, 189);
            this.dgvCategoria.TabIndex = 21;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 394);
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
    }
}