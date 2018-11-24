namespace Presentacion
{
    partial class frmComentarioBaja
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
            this.btnOK = new System.Windows.Forms.Button();
            this.rtxComentario = new System.Windows.Forms.RichTextBox();
            this.dtpBaja = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOK.Location = new System.Drawing.Point(87, 126);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 35);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // rtxComentario
            // 
            this.rtxComentario.BackColor = System.Drawing.SystemColors.Control;
            this.rtxComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxComentario.Location = new System.Drawing.Point(14, 14);
            this.rtxComentario.Margin = new System.Windows.Forms.Padding(5);
            this.rtxComentario.Name = "rtxComentario";
            this.rtxComentario.Size = new System.Drawing.Size(256, 32);
            this.rtxComentario.TabIndex = 23;
            this.rtxComentario.Text = "";
            // 
            // dtpBaja
            // 
            this.dtpBaja.Location = new System.Drawing.Point(14, 73);
            this.dtpBaja.Name = "dtpBaja";
            this.dtpBaja.Size = new System.Drawing.Size(256, 20);
            this.dtpBaja.TabIndex = 25;
            // 
            // frmComentarioBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.dtpBaja);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rtxComentario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComentarioBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmComentarioBaja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RichTextBox rtxComentario;
        private System.Windows.Forms.DateTimePicker dtpBaja;
    }
}