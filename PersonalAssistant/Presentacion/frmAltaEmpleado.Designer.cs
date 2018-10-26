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
            this.lblLocalidad = new System.Windows.Forms.Label();
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
            this.cbxLocalidad = new System.Windows.Forms.ComboBox();
            this.cbxPartido = new System.Windows.Forms.ComboBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.txbBasico = new System.Windows.Forms.TextBox();
            this.lblBasico = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudHijos)).BeginInit();
            this.gbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Location = new System.Drawing.Point(245, 504);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 31);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "GUARDAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(175, 179);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(156, 20);
            this.txbNombre.TabIndex = 6;
            this.txbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(105, 182);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(439, 181);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(156, 20);
            this.txbApellido.TabIndex = 7;
            this.txbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(363, 180);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(470, 12);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAlta.TabIndex = 25;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(119, 11);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(66, 18);
            this.lblContrato.TabIndex = 20;
            this.lblContrato.Text = "Contrato";
            // 
            // cbxContrato
            // 
            this.cbxContrato.FormattingEnabled = true;
            this.cbxContrato.Location = new System.Drawing.Point(195, 10);
            this.cbxContrato.Name = "cbxContrato";
            this.cbxContrato.Size = new System.Drawing.Size(145, 21);
            this.cbxContrato.TabIndex = 0;
            this.cbxContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxContrato_KeyPress);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(438, 94);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(144, 21);
            this.cbxCategoria.TabIndex = 3;
            this.cbxCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCategoria_KeyPress);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(348, 96);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 18);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbxSeccion
            // 
            this.cbxSeccion.FormattingEnabled = true;
            this.cbxSeccion.Location = new System.Drawing.Point(198, 53);
            this.cbxSeccion.Name = "cbxSeccion";
            this.cbxSeccion.Size = new System.Drawing.Size(144, 21);
            this.cbxSeccion.TabIndex = 1;
            this.cbxSeccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSeccion_KeyPress);
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(130, 54);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(62, 18);
            this.lblSeccion.TabIndex = 24;
            this.lblSeccion.Text = "Sección";
            // 
            // cbxConcepto
            // 
            this.cbxConcepto.FormattingEnabled = true;
            this.cbxConcepto.Location = new System.Drawing.Point(438, 55);
            this.cbxConcepto.Name = "cbxConcepto";
            this.cbxConcepto.Size = new System.Drawing.Size(144, 21);
            this.cbxConcepto.TabIndex = 2;
            this.cbxConcepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxConcepto_KeyPress);
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(347, 56);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(73, 18);
            this.lblConcepto.TabIndex = 26;
            this.lblConcepto.Text = "Concepto";
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(175, 221);
            this.txbDni.MaxLength = 8;
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(156, 20);
            this.txbDni.TabIndex = 8;
            this.txbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(134, 223);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 18);
            this.lblDni.TabIndex = 28;
            this.lblDni.Text = "DNI";
            // 
            // txbCuil
            // 
            this.txbCuil.Location = new System.Drawing.Point(439, 222);
            this.txbCuil.MaxLength = 11;
            this.txbCuil.Name = "txbCuil";
            this.txbCuil.Size = new System.Drawing.Size(156, 20);
            this.txbCuil.TabIndex = 9;
            this.txbCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCuil_KeyPress);
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuil.Location = new System.Drawing.Point(381, 222);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(41, 18);
            this.lblCuil.TabIndex = 30;
            this.lblCuil.Text = "CUIL";
            // 
            // cbxConvenio
            // 
            this.cbxConvenio.FormattingEnabled = true;
            this.cbxConvenio.Location = new System.Drawing.Point(206, 131);
            this.cbxConvenio.Name = "cbxConvenio";
            this.cbxConvenio.Size = new System.Drawing.Size(121, 21);
            this.cbxConvenio.TabIndex = 4;
            this.cbxConvenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxConvenio_KeyPress);
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.Location = new System.Drawing.Point(118, 133);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(71, 18);
            this.lblConvenio.TabIndex = 32;
            this.lblConvenio.Text = "Convenio";
            // 
            // txbObraSocial
            // 
            this.txbObraSocial.Location = new System.Drawing.Point(439, 131);
            this.txbObraSocial.Name = "txbObraSocial";
            this.txbObraSocial.Size = new System.Drawing.Size(156, 20);
            this.txbObraSocial.TabIndex = 5;
            this.txbObraSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbObraSocial_KeyPress);
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraSocial.Location = new System.Drawing.Point(343, 131);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(86, 18);
            this.lblObraSocial.TabIndex = 34;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // txbDomicilio
            // 
            this.txbDomicilio.Location = new System.Drawing.Point(175, 263);
            this.txbDomicilio.Name = "txbDomicilio";
            this.txbDomicilio.Size = new System.Drawing.Size(156, 20);
            this.txbDomicilio.TabIndex = 10;
            this.txbDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDomicilio_KeyPress);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(97, 264);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(70, 18);
            this.lblDomicilio.TabIndex = 36;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txbEntrecalles1
            // 
            this.txbEntrecalles1.Location = new System.Drawing.Point(439, 263);
            this.txbEntrecalles1.Name = "txbEntrecalles1";
            this.txbEntrecalles1.Size = new System.Drawing.Size(156, 20);
            this.txbEntrecalles1.TabIndex = 11;
            this.txbEntrecalles1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEntrecalles1_KeyPress);
            // 
            // lblEntreCalles
            // 
            this.lblEntreCalles.AutoSize = true;
            this.lblEntreCalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntreCalles.Location = new System.Drawing.Point(341, 264);
            this.lblEntreCalles.Name = "lblEntreCalles";
            this.lblEntreCalles.Size = new System.Drawing.Size(81, 18);
            this.lblEntreCalles.TabIndex = 38;
            this.lblEntreCalles.Text = "Entrecalles";
            // 
            // txbEntrecalles2
            // 
            this.txbEntrecalles2.Location = new System.Drawing.Point(617, 264);
            this.txbEntrecalles2.Name = "txbEntrecalles2";
            this.txbEntrecalles2.Size = new System.Drawing.Size(156, 20);
            this.txbEntrecalles2.TabIndex = 12;
            this.txbEntrecalles2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEntrecalles2_KeyPress);
            // 
            // txbCP
            // 
            this.txbCP.Location = new System.Drawing.Point(175, 312);
            this.txbCP.MaxLength = 4;
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(59, 20);
            this.txbCP.TabIndex = 13;
            this.txbCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCP_KeyPress);
            this.txbCP.Validated += new System.EventHandler(this.txbCP_Validated);
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCp.Location = new System.Drawing.Point(138, 314);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(29, 18);
            this.lblCp.TabIndex = 41;
            this.lblCp.Text = "CP";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(264, 314);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(71, 18);
            this.lblLocalidad.TabIndex = 43;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.Location = new System.Drawing.Point(526, 314);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(55, 18);
            this.lblPartido.TabIndex = 45;
            this.lblPartido.Text = "Partido";
            // 
            // txbTelefonoPrincipal
            // 
            this.txbTelefonoPrincipal.Location = new System.Drawing.Point(175, 355);
            this.txbTelefonoPrincipal.MaxLength = 15;
            this.txbTelefonoPrincipal.Name = "txbTelefonoPrincipal";
            this.txbTelefonoPrincipal.Size = new System.Drawing.Size(156, 20);
            this.txbTelefonoPrincipal.TabIndex = 16;
            this.txbTelefonoPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelefonoPrincipal_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(41, 355);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(126, 18);
            this.lblTelefono.TabIndex = 47;
            this.lblTelefono.Text = "Telefono Principal";
            // 
            // txbTelefonoAlternativo
            // 
            this.txbTelefonoAlternativo.Location = new System.Drawing.Point(556, 355);
            this.txbTelefonoAlternativo.MaxLength = 30;
            this.txbTelefonoAlternativo.Name = "txbTelefonoAlternativo";
            this.txbTelefonoAlternativo.Size = new System.Drawing.Size(183, 20);
            this.txbTelefonoAlternativo.TabIndex = 17;
            this.txbTelefonoAlternativo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelefonoAlternativo_KeyPress);
            // 
            // lblTelefonoAlternativo
            // 
            this.lblTelefonoAlternativo.AutoSize = true;
            this.lblTelefonoAlternativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlternativo.Location = new System.Drawing.Point(395, 353);
            this.lblTelefonoAlternativo.Name = "lblTelefonoAlternativo";
            this.lblTelefonoAlternativo.Size = new System.Drawing.Size(138, 18);
            this.lblTelefonoAlternativo.TabIndex = 49;
            this.lblTelefonoAlternativo.Text = "Telefono Alternativo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFechaNac.Location = new System.Drawing.Point(257, 390);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 18;
            // 
            // txbNacionalidad
            // 
            this.txbNacionalidad.Location = new System.Drawing.Point(583, 390);
            this.txbNacionalidad.Name = "txbNacionalidad";
            this.txbNacionalidad.Size = new System.Drawing.Size(156, 20);
            this.txbNacionalidad.TabIndex = 19;
            this.txbNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNacionalidad_KeyPress);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(469, 390);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(93, 18);
            this.lblNacionalidad.TabIndex = 53;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Location = new System.Drawing.Point(183, 431);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoCivil.TabIndex = 20;
            this.cbxEstadoCivil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxEstadoCivil_KeyPress);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(84, 432);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(86, 18);
            this.lblEstadoCivil.TabIndex = 55;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijos.Location = new System.Drawing.Point(356, 432);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(42, 18);
            this.lblHijos.TabIndex = 57;
            this.lblHijos.Text = "Hijos";
            // 
            // nudHijos
            // 
            this.nudHijos.Location = new System.Drawing.Point(410, 431);
            this.nudHijos.Name = "nudHijos";
            this.nudHijos.Size = new System.Drawing.Size(34, 20);
            this.nudHijos.TabIndex = 21;
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.Location = new System.Drawing.Point(396, 13);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(32, 18);
            this.lblAlta.TabIndex = 59;
            this.lblAlta.Text = "Alta";
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLocalidad.FormattingEnabled = true;
            this.cbxLocalidad.Location = new System.Drawing.Point(341, 312);
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.Size = new System.Drawing.Size(178, 21);
            this.cbxLocalidad.TabIndex = 14;
            this.cbxLocalidad.SelectedIndexChanged += new System.EventHandler(this.cbxLocalidad_SelectedIndexChanged);
            this.cbxLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxLocalidad_KeyPress);
            // 
            // cbxPartido
            // 
            this.cbxPartido.FormattingEnabled = true;
            this.cbxPartido.Location = new System.Drawing.Point(591, 311);
            this.cbxPartido.Name = "cbxPartido";
            this.cbxPartido.Size = new System.Drawing.Size(148, 21);
            this.cbxPartido.TabIndex = 15;
            this.cbxPartido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxPartido_KeyPress);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rdbFemenino);
            this.gbxSexo.Controls.Add(this.rdbMasculino);
            this.gbxSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(716, 188);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(106, 65);
            this.gbxSexo.TabIndex = 23;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(7, 41);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(89, 21);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(7, 16);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(90, 21);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // txbBasico
            // 
            this.txbBasico.Location = new System.Drawing.Point(643, 432);
            this.txbBasico.MaxLength = 7;
            this.txbBasico.Name = "txbBasico";
            this.txbBasico.Size = new System.Drawing.Size(59, 20);
            this.txbBasico.TabIndex = 22;
            // 
            // lblBasico
            // 
            this.lblBasico.AutoSize = true;
            this.lblBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasico.Location = new System.Drawing.Point(588, 434);
            this.lblBasico.Name = "lblBasico";
            this.lblBasico.Size = new System.Drawing.Size(54, 18);
            this.lblBasico.TabIndex = 64;
            this.lblBasico.Text = "Basico";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCerrar.Location = new System.Drawing.Point(483, 504);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(213, 31);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxFoto
            // 
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Location = new System.Drawing.Point(706, 8);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(134, 134);
            this.pbxFoto.TabIndex = 66;
            this.pbxFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFoto.Location = new System.Drawing.Point(665, 151);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(213, 31);
            this.btnFoto.TabIndex = 24;
            this.btnFoto.Text = "CARGAR FOTO";
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNo);
            this.groupBox1.Controls.Add(this.rdbSi);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(734, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 65);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROL HORARIO";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(7, 41);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(47, 21);
            this.rdbNo.TabIndex = 1;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "NO";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(7, 16);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(35, 21);
            this.rdbSi.TabIndex = 0;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "SI";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txbBasico);
            this.Controls.Add(this.lblBasico);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.cbxPartido);
            this.Controls.Add(this.cbxLocalidad);
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
            this.Controls.Add(this.lblPartido);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAltaEmpleado";
            this.Load += new System.EventHandler(this.frmAltaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHijos)).EndInit();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblLocalidad;
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
        private System.Windows.Forms.ComboBox cbxLocalidad;
        private System.Windows.Forms.ComboBox cbxPartido;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.TextBox txbBasico;
        private System.Windows.Forms.Label lblBasico;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
    }
}