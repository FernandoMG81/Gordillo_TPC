namespace Presentacion
{
    partial class frmModificarEmpleado
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.dgvEmpleadosActivos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tbcListadoEmpleados = new System.Windows.Forms.TabControl();
            this.tbpActivos = new System.Windows.Forms.TabPage();
            this.tbpBaja = new System.Windows.Forms.TabPage();
            this.dgvEmpleadosBaja = new System.Windows.Forms.DataGridView();
            this.tbpLegajo = new System.Windows.Forms.TabPage();
            this.dgvLegajos = new System.Windows.Forms.DataGridView();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosActivos)).BeginInit();
            this.tbcListadoEmpleados.SuspendLayout();
            this.tbpActivos.SuspendLayout();
            this.tbpBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosBaja)).BeginInit();
            this.tbpLegajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLegajos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(420, 45);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(59, 20);
            this.lblBuscar.TabIndex = 21;
            this.lblBuscar.Text = "Buscar";
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(612, 44);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(230, 20);
            this.txbBuscar.TabIndex = 22;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // dgvEmpleadosActivos
            // 
            this.dgvEmpleadosActivos.AllowUserToAddRows = false;
            this.dgvEmpleadosActivos.AllowUserToDeleteRows = false;
            this.dgvEmpleadosActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleadosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleadosActivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvEmpleadosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosActivos.Location = new System.Drawing.Point(3, 5);
            this.dgvEmpleadosActivos.MultiSelect = false;
            this.dgvEmpleadosActivos.Name = "dgvEmpleadosActivos";
            this.dgvEmpleadosActivos.ReadOnly = true;
            this.dgvEmpleadosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosActivos.Size = new System.Drawing.Size(840, 375);
            this.dgvEmpleadosActivos.TabIndex = 23;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.Location = new System.Drawing.Point(753, 510);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 21);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaja.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBaja.Location = new System.Drawing.Point(645, 510);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(89, 21);
            this.btnBaja.TabIndex = 25;
            this.btnBaja.Text = "BAJA";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // tbcListadoEmpleados
            // 
            this.tbcListadoEmpleados.Controls.Add(this.tbpActivos);
            this.tbcListadoEmpleados.Controls.Add(this.tbpBaja);
            this.tbcListadoEmpleados.Controls.Add(this.tbpLegajo);
            this.tbcListadoEmpleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcListadoEmpleados.Location = new System.Drawing.Point(12, 74);
            this.tbcListadoEmpleados.Name = "tbcListadoEmpleados";
            this.tbcListadoEmpleados.SelectedIndex = 0;
            this.tbcListadoEmpleados.Size = new System.Drawing.Size(857, 418);
            this.tbcListadoEmpleados.TabIndex = 28;
            this.tbcListadoEmpleados.SelectedIndexChanged += new System.EventHandler(this.tbcListadoEmpleados_SelectedIndexChanged);
          
            // 
            // tbpActivos
            // 
            this.tbpActivos.Controls.Add(this.dgvEmpleadosActivos);
            this.tbpActivos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpActivos.Location = new System.Drawing.Point(4, 28);
            this.tbpActivos.Name = "tbpActivos";
            this.tbpActivos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpActivos.Size = new System.Drawing.Size(849, 386);
            this.tbpActivos.TabIndex = 0;
            this.tbpActivos.Text = "ACTIVOS";
            this.tbpActivos.UseVisualStyleBackColor = true;
            // 
            // tbpBaja
            // 
            this.tbpBaja.Controls.Add(this.dgvEmpleadosBaja);
            this.tbpBaja.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpBaja.Location = new System.Drawing.Point(4, 28);
            this.tbpBaja.Name = "tbpBaja";
            this.tbpBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBaja.Size = new System.Drawing.Size(849, 386);
            this.tbpBaja.TabIndex = 1;
            this.tbpBaja.Text = "BAJA";
            this.tbpBaja.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleadosBaja
            // 
            this.dgvEmpleadosBaja.AllowUserToAddRows = false;
            this.dgvEmpleadosBaja.AllowUserToDeleteRows = false;
            this.dgvEmpleadosBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleadosBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleadosBaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvEmpleadosBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosBaja.Location = new System.Drawing.Point(3, 5);
            this.dgvEmpleadosBaja.MultiSelect = false;
            this.dgvEmpleadosBaja.Name = "dgvEmpleadosBaja";
            this.dgvEmpleadosBaja.ReadOnly = true;
            this.dgvEmpleadosBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosBaja.Size = new System.Drawing.Size(840, 376);
            this.dgvEmpleadosBaja.TabIndex = 24;
            // 
            // tbpLegajo
            // 
            this.tbpLegajo.Controls.Add(this.dgvLegajos);
            this.tbpLegajo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpLegajo.Location = new System.Drawing.Point(4, 28);
            this.tbpLegajo.Name = "tbpLegajo";
            this.tbpLegajo.Size = new System.Drawing.Size(849, 386);
            this.tbpLegajo.TabIndex = 2;
            this.tbpLegajo.Text = "SIN LEGAJO";
            this.tbpLegajo.UseVisualStyleBackColor = true;
            // 
            // dgvLegajos
            // 
            this.dgvLegajos.AllowUserToAddRows = false;
            this.dgvLegajos.AllowUserToDeleteRows = false;
            this.dgvLegajos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLegajos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLegajos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvLegajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLegajos.Location = new System.Drawing.Point(4, 5);
            this.dgvLegajos.MultiSelect = false;
            this.dgvLegajos.Name = "dgvLegajos";
            this.dgvLegajos.ReadOnly = true;
            this.dgvLegajos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLegajos.Size = new System.Drawing.Size(842, 378);
            this.dgvLegajos.TabIndex = 25;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "Apellido",
            "Nombre"});
            this.cbxBuscar.Location = new System.Drawing.Point(485, 44);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(121, 21);
            this.cbxBuscar.TabIndex = 29;
            // 
            // frmModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 565);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.tbcListadoEmpleados);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.lblBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarEmpleado";
            this.Text = "frmModificarEmpleado";
            this.Load += new System.EventHandler(this.frmModificarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosActivos)).EndInit();
            this.tbcListadoEmpleados.ResumeLayout(false);
            this.tbpActivos.ResumeLayout(false);
            this.tbpBaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosBaja)).EndInit();
            this.tbpLegajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLegajos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.DataGridView dgvEmpleadosActivos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TabControl tbcListadoEmpleados;
        private System.Windows.Forms.TabPage tbpActivos;
        private System.Windows.Forms.TabPage tbpBaja;
        private System.Windows.Forms.DataGridView dgvEmpleadosBaja;
        private System.Windows.Forms.TabPage tbpLegajo;
        private System.Windows.Forms.DataGridView dgvLegajos;
        private System.Windows.Forms.ComboBox cbxBuscar;
    }
}