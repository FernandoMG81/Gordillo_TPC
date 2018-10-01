namespace Presentacion
{
    partial class frmAltaEquipo
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
            this.dgvListaEquipos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbIMEI = new System.Windows.Forms.TextBox();
            this.lblIMEI = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txbComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEquipos
            // 
            this.dgvListaEquipos.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvListaEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEquipos.Location = new System.Drawing.Point(30, 158);
            this.dgvListaEquipos.Name = "dgvListaEquipos";
            this.dgvListaEquipos.Size = new System.Drawing.Size(541, 199);
            this.dgvListaEquipos.TabIndex = 5;
            this.dgvListaEquipos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Location = new System.Drawing.Point(207, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 31);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbIMEI
            // 
            this.txbIMEI.Location = new System.Drawing.Point(105, 40);
            this.txbIMEI.Name = "txbIMEI";
            this.txbIMEI.Size = new System.Drawing.Size(156, 20);
            this.txbIMEI.TabIndex = 0;
            // 
            // lblIMEI
            // 
            this.lblIMEI.AutoSize = true;
            this.lblIMEI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMEI.Location = new System.Drawing.Point(33, 40);
            this.lblIMEI.Name = "lblIMEI";
            this.lblIMEI.Size = new System.Drawing.Size(44, 21);
            this.lblIMEI.TabIndex = 15;
            this.lblIMEI.Text = "IMEI";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(105, 76);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(156, 20);
            this.txbMarca.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(33, 76);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(62, 21);
            this.lblMarca.TabIndex = 19;
            this.lblMarca.Text = "Marca";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(370, 39);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(156, 20);
            this.txbModelo.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(298, 39);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(69, 21);
            this.lblModelo.TabIndex = 21;
            this.lblModelo.Text = "Modelo";
            // 
            // txbComentario
            // 
            this.txbComentario.Location = new System.Drawing.Point(370, 76);
            this.txbComentario.Name = "txbComentario";
            this.txbComentario.Size = new System.Drawing.Size(156, 20);
            this.txbComentario.TabIndex = 3;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(268, 76);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(104, 21);
            this.lblComentario.TabIndex = 23;
            this.lblComentario.Text = "Comentario";
            // 
            // frmAltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 368);
            this.Controls.Add(this.txbComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dgvListaEquipos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbIMEI);
            this.Controls.Add(this.lblIMEI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaEquipo";
            this.Text = "frmAltaEquipo";
            this.Load += new System.EventHandler(this.frmAltaEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEquipos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbIMEI;
        private System.Windows.Forms.Label lblIMEI;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txbComentario;
        private System.Windows.Forms.Label lblComentario;
    }
}