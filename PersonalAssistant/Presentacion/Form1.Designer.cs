namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.rtbNovedades = new System.Windows.Forms.RichTextBox();
            this.lblNovedades = new System.Windows.Forms.Label();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaEmpleado.BackColor = System.Drawing.Color.White;
            this.btnAltaEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaEmpleado.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnAltaEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAltaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaEmpleado.ForeColor = System.Drawing.Color.Green;
            this.btnAltaEmpleado.Location = new System.Drawing.Point(420, 65);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(255, 103);
            this.btnAltaEmpleado.TabIndex = 0;
            this.btnAltaEmpleado.Text = "ALTA EMPLEADO";
            this.btnAltaEmpleado.UseVisualStyleBackColor = false;
            // 
            // rtbNovedades
            // 
            this.rtbNovedades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNovedades.Enabled = false;
            this.rtbNovedades.Location = new System.Drawing.Point(743, 302);
            this.rtbNovedades.Name = "rtbNovedades";
            this.rtbNovedades.Size = new System.Drawing.Size(327, 285);
            this.rtbNovedades.TabIndex = 2;
            this.rtbNovedades.Text = "";
            // 
            // lblNovedades
            // 
            this.lblNovedades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNovedades.AutoSize = true;
            this.lblNovedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovedades.Location = new System.Drawing.Point(849, 273);
            this.lblNovedades.Name = "lblNovedades";
            this.lblNovedades.Size = new System.Drawing.Size(122, 26);
            this.lblNovedades.TabIndex = 3;
            this.lblNovedades.Text = "Novedades";
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(442, 224);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(214, 64);
            this.btnModificarEmpleado.TabIndex = 4;
            this.btnModificarEmpleado.Text = "Modificar empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 108);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1082, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.lblNovedades);
            this.Controls.Add(this.rtbNovedades);
            this.Controls.Add(this.btnAltaEmpleado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEmpleado;
        private System.Windows.Forms.RichTextBox rtbNovedades;
        private System.Windows.Forms.Label lblNovedades;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button button1;
    }
}

