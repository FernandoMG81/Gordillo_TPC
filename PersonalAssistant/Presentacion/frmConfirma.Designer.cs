namespace Presentacion
{
    partial class frmConfirma
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblMensaje.Location = new System.Drawing.Point(13, 21);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(67, 19);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Mensaje";
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSi.FlatAppearance.BorderSize = 0;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSi.Location = new System.Drawing.Point(119, 62);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(61, 30);
            this.btnSi.TabIndex = 18;
            this.btnSi.Text = "SI";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNo.Location = new System.Drawing.Point(246, 62);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(61, 30);
            this.btnNo.TabIndex = 19;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmConfirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 118);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConfirma";
            this.Load += new System.EventHandler(this.frmConfirma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
    }
}