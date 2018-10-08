namespace Presentacion
{
    partial class frmAltaEmpleado
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.lblContrato = new System.Windows.Forms.Label();
            this.cbxContrato = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxSeccion = new System.Windows.Forms.ComboBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.cbxConcepto = new System.Windows.Forms.ComboBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txbCuil = new System.Windows.Forms.TextBox();
            this.lblCuil = new System.Windows.Forms.Label();
            this.cbxConvenio = new System.Windows.Forms.ComboBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.txbObraSocial = new System.Windows.Forms.TextBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.txbDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txbEntrecalles1 = new System.Windows.Forms.TextBox();
            this.lblEntreCalles = new System.Windows.Forms.Label();
            this.txbEntrecalles2 = new System.Windows.Forms.TextBox();
            this.txbCP = new System.Windows.Forms.TextBox();
            this.lblCp = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txbPartido = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.txbTelefonoPrincipal = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txbTelefonoAlternativo = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlternativo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txbNacionalidad = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.cbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblHijos = new System.Windows.Forms.Label();
            this.nudHijos = new System.Windows.Forms.NumericUpDown();
            this.lblAlta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHijos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Location = new System.Drawing.Point(250, 368);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 31);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(105, 50);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(156, 20);
            this.txbNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(388, 50);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(156, 20);
            this.txbApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(316, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(501, 8);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAlta.TabIndex = 0;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(209, 9);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(66, 18);
            this.lblContrato.TabIndex = 20;
            this.lblContrato.Text = "Contrato";
            // 
            // cbxContrato
            // 
            this.cbxContrato.FormattingEnabled = true;
            this.cbxContrato.Location = new System.Drawing.Point(290, 8);
            this.cbxContrato.Name = "cbxContrato";
            this.cbxContrato.Size = new System.Drawing.Size(145, 21);
            this.cbxContrato.TabIndex = 1;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(576, 121);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(486, 123);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 18);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbxSeccion
            // 
            this.cbxSeccion.FormattingEnabled = true;
            this.cbxSeccion.Location = new System.Drawing.Point(105, 122);
            this.cbxSeccion.Name = "cbxSeccion";
            this.cbxSeccion.Size = new System.Drawing.Size(121, 21);
            this.cbxSeccion.TabIndex = 6;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(37, 123);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(62, 18);
            this.lblSeccion.TabIndex = 24;
            this.lblSeccion.Text = "Sección";
            // 
            // cbxConcepto
            // 
            this.cbxConcepto.FormattingEnabled = true;
            this.cbxConcepto.Location = new System.Drawing.Point(336, 122);
            this.cbxConcepto.Name = "cbxConcepto";
            this.cbxConcepto.Size = new System.Drawing.Size(144, 21);
            this.cbxConcepto.TabIndex = 7;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(245, 123);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(73, 18);
            this.lblConcepto.TabIndex = 26;
            this.lblConcepto.Text = "Concepto";
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(106, 81);
            this.txbDni.MaxLength = 8;
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(156, 20);
            this.txbDni.TabIndex = 4;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(65, 81);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 18);
            this.lblDni.TabIndex = 28;
            this.lblDni.Text = "DNI";
            // 
            // txbCuil
            // 
            this.txbCuil.Location = new System.Drawing.Point(388, 81);
            this.txbCuil.MaxLength = 11;
            this.txbCuil.Name = "txbCuil";
            this.txbCuil.Size = new System.Drawing.Size(156, 20);
            this.txbCuil.TabIndex = 5;
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuil.Location = new System.Drawing.Point(341, 81);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(41, 18);
            this.lblCuil.TabIndex = 30;
            this.lblCuil.Text = "CUIL";
            // 
            // cbxConvenio
            // 
            this.cbxConvenio.FormattingEnabled = true;
            this.cbxConvenio.Location = new System.Drawing.Point(105, 152);
            this.cbxConvenio.Name = "cbxConvenio";
            this.cbxConvenio.Size = new System.Drawing.Size(121, 21);
            this.cbxConvenio.TabIndex = 9;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.Location = new System.Drawing.Point(17, 154);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(71, 18);
            this.lblConvenio.TabIndex = 32;
            this.lblConvenio.Text = "Convenio";
            // 
            // txbObraSocial
            // 
            this.txbObraSocial.Location = new System.Drawing.Point(338, 152);
            this.txbObraSocial.Name = "txbObraSocial";
            this.txbObraSocial.Size = new System.Drawing.Size(156, 20);
            this.txbObraSocial.TabIndex = 10;
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraSocial.Location = new System.Drawing.Point(242, 152);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(86, 18);
            this.lblObraSocial.TabIndex = 34;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // txbDomicilio
            // 
            this.txbDomicilio.Location = new System.Drawing.Point(105, 187);
            this.txbDomicilio.Name = "txbDomicilio";
            this.txbDomicilio.Size = new System.Drawing.Size(156, 20);
            this.txbDomicilio.TabIndex = 11;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(31, 187);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(70, 18);
            this.lblDomicilio.TabIndex = 36;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txbEntrecalles1
            // 
            this.txbEntrecalles1.Location = new System.Drawing.Point(375, 187);
            this.txbEntrecalles1.Name = "txbEntrecalles1";
            this.txbEntrecalles1.Size = new System.Drawing.Size(156, 20);
            this.txbEntrecalles1.TabIndex = 12;
            // 
            // lblEntreCalles
            // 
            this.lblEntreCalles.AutoSize = true;
            this.lblEntreCalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntreCalles.Location = new System.Drawing.Point(284, 187);
            this.lblEntreCalles.Name = "lblEntreCalles";
            this.lblEntreCalles.Size = new System.Drawing.Size(81, 18);
            this.lblEntreCalles.TabIndex = 38;
            this.lblEntreCalles.Text = "Entrecalles";
            // 
            // txbEntrecalles2
            // 
            this.txbEntrecalles2.Location = new System.Drawing.Point(545, 187);
            this.txbEntrecalles2.Name = "txbEntrecalles2";
            this.txbEntrecalles2.Size = new System.Drawing.Size(156, 20);
            this.txbEntrecalles2.TabIndex = 13;
            // 
            // txbCP
            // 
            this.txbCP.Location = new System.Drawing.Point(104, 222);
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(59, 20);
            this.txbCP.TabIndex = 14;
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCp.Location = new System.Drawing.Point(63, 222);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(29, 18);
            this.lblCp.TabIndex = 41;
            this.lblCp.Text = "CP";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 15;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(192, 222);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(71, 18);
            this.lblLocalidad.TabIndex = 43;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txbPartido
            // 
            this.txbPartido.Location = new System.Drawing.Point(526, 222);
            this.txbPartido.Name = "txbPartido";
            this.txbPartido.Size = new System.Drawing.Size(156, 20);
            this.txbPartido.TabIndex = 16;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.Location = new System.Drawing.Point(454, 222);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(55, 18);
            this.lblPartido.TabIndex = 45;
            this.lblPartido.Text = "Partido";
            // 
            // txbTelefonoPrincipal
            // 
            this.txbTelefonoPrincipal.Location = new System.Drawing.Point(147, 254);
            this.txbTelefonoPrincipal.Name = "txbTelefonoPrincipal";
            this.txbTelefonoPrincipal.Size = new System.Drawing.Size(156, 20);
            this.txbTelefonoPrincipal.TabIndex = 17;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(4, 254);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(126, 18);
            this.lblTelefono.TabIndex = 47;
            this.lblTelefono.Text = "Telefono Principal";
            // 
            // txbTelefonoAlternativo
            // 
            this.txbTelefonoAlternativo.Location = new System.Drawing.Point(484, 252);
            this.txbTelefonoAlternativo.Name = "txbTelefonoAlternativo";
            this.txbTelefonoAlternativo.Size = new System.Drawing.Size(156, 20);
            this.txbTelefonoAlternativo.TabIndex = 18;
            // 
            // lblTelefonoAlternativo
            // 
            this.lblTelefonoAlternativo.AutoSize = true;
            this.lblTelefonoAlternativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlternativo.Location = new System.Drawing.Point(323, 252);
            this.lblTelefonoAlternativo.Name = "lblTelefonoAlternativo";
            this.lblTelefonoAlternativo.Size = new System.Drawing.Size(138, 18);
            this.lblTelefonoAlternativo.TabIndex = 49;
            this.lblTelefonoAlternativo.Text = "Telefono Alternativo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(185, 289);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 19;
            // 
            // txbNacionalidad
            // 
            this.txbNacionalidad.Location = new System.Drawing.Point(511, 289);
            this.txbNacionalidad.Name = "txbNacionalidad";
            this.txbNacionalidad.Size = new System.Drawing.Size(156, 20);
            this.txbNacionalidad.TabIndex = 20;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(397, 289);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(93, 18);
            this.lblNacionalidad.TabIndex = 53;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Location = new System.Drawing.Point(111, 330);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoCivil.TabIndex = 21;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(12, 331);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(86, 18);
            this.lblEstadoCivil.TabIndex = 55;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijos.Location = new System.Drawing.Point(284, 331);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(42, 18);
            this.lblHijos.TabIndex = 57;
            this.lblHijos.Text = "Hijos";
            // 
            // nudHijos
            // 
            this.nudHijos.Location = new System.Drawing.Point(338, 330);
            this.nudHijos.Name = "nudHijos";
            this.nudHijos.Size = new System.Drawing.Size(34, 20);
            this.nudHijos.TabIndex = 22;
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.Location = new System.Drawing.Point(457, 9);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(32, 18);
            this.lblAlta.TabIndex = 59;
            this.lblAlta.Text = "Alta";
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 411);
            this.Controls.Add(this.lblAlta);
            this.Controls.Add(this.nudHijos);
            this.Controls.Add(this.lblHijos);
            this.Controls.Add(this.cbxEstadoCivil);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.txbNacionalidad);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTelefonoAlternativo);
            this.Controls.Add(this.lblTelefonoAlternativo);
            this.Controls.Add(this.txbTelefonoPrincipal);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txbPartido);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txbCP);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.txbEntrecalles2);
            this.Controls.Add(this.txbEntrecalles1);
            this.Controls.Add(this.lblEntreCalles);
            this.Controls.Add(this.txbDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txbObraSocial);
            this.Controls.Add(this.lblObraSocial);
            this.Controls.Add(this.cbxConvenio);
            this.Controls.Add(this.lblConvenio);
            this.Controls.Add(this.txbCuil);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.cbxConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.cbxSeccion);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxContrato);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaEmpleado";
            this.Text = "frmAltaEmpleado";
            this.Load += new System.EventHandler(this.frmAltaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHijos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.ComboBox cbxContrato;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxSeccion;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.ComboBox cbxConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txbCuil;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.ComboBox cbxConvenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.TextBox txbObraSocial;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.TextBox txbDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txbEntrecalles1;
        private System.Windows.Forms.Label lblEntreCalles;
        private System.Windows.Forms.TextBox txbEntrecalles2;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txbPartido;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.TextBox txbTelefonoPrincipal;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txbTelefonoAlternativo;
        private System.Windows.Forms.Label lblTelefonoAlternativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txbNacionalidad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.ComboBox cbxEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblHijos;
        private System.Windows.Forms.NumericUpDown nudHijos;
        private System.Windows.Forms.Label lblAlta;
    }
}