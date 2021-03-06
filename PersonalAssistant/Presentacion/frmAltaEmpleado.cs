﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Personal;
using System.Data.SqlClient;
using System.IO;



namespace Presentacion
{
    public partial class frmAltaEmpleado : Form
    {
        private Usuario usuarioLogueado;
        private Empleado empleado = null;
        private bool completo = false;

        public frmAltaEmpleado(Usuario user)
        {
            InitializeComponent();
            usuarioLogueado = user;
        }

        public frmAltaEmpleado(Empleado nuevo, Usuario user)
        {
            InitializeComponent();
            empleado = nuevo;
            usuarioLogueado = user;
        }

        private void FrmAltaEmpleado_Load(object sender, EventArgs e)
        {

            ConceptoPersonal concepto = new ConceptoPersonal();
            CategoriaPersonal categoria = new CategoriaPersonal();
            ContratoPersonal contrato = new ContratoPersonal();
            SeccionPersonal seccion = new SeccionPersonal();
            ConvenioPersonal convenio = new ConvenioPersonal();
            EstadoCivilPersonal estadoCivil = new EstadoCivilPersonal();


            try
            {

                cbxConcepto.DataSource = concepto.listar();
                cbxConcepto.ValueMember = "IdConcepto";
                cbxConcepto.DisplayMember = "nombre";

                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "Idcategoria";
                cbxCategoria.DisplayMember = "nombre";

                cbxContrato.DataSource = contrato.listar();
                cbxContrato.ValueMember = "Idcontrato";
                cbxContrato.DisplayMember = "Descripcion";

                cbxSeccion.DataSource = seccion.listar();
                cbxSeccion.ValueMember = "Idseccion";
                cbxSeccion.DisplayMember = "nombre";

                cbxConvenio.DataSource = convenio.listar();
                cbxConvenio.ValueMember = "IDconvenio";
                cbxConvenio.DisplayMember = "Descripcion";

                cbxEstadoCivil.DataSource = estadoCivil.listar();
                cbxEstadoCivil.ValueMember = "IdEstadoCivil";
                cbxEstadoCivil.DisplayMember = "Descripcion";

                CargarLocalidad();
                CargarPartido();



                if (empleado != null)
                {
                    btnCerrar.Visible = true;
                    cbxContrato.SelectedValue = empleado.Contrato.Idcontrato;
                    dtpFechaAlta.Value = empleado.FechaAlta;
                    txbNombre.Text = empleado.Nombre;
                    txbApellido.Text = empleado.Apellido;
                    txbDni.Text = empleado.Dni;
                    txbCuil.Text = empleado.Cuil;
                    if (empleado.Sexo == 'M') rdbMasculino.Checked = true;
                    else rdbFemenino.Checked = true;
                    cbxSeccion.SelectedValue = empleado.Seccion.Idseccion;
                    cbxConcepto.SelectedValue = empleado.Concepto.IdConcepto;
                    cbxCategoria.SelectedValue = empleado.Categoria.Idcategoria;
                    cbxConvenio.SelectedValue = empleado.Convenio.IDconvenio;
                    txbObraSocial.Text = empleado.ObraSocial;
                    txbDomicilio.Text = empleado.Domicilio;
                    txbEntrecalles1.Text = empleado.Entrecalle1;
                    txbEntrecalles2.Text = empleado.Entrecalle2;
                    txbCP.Text = empleado.Localidad.cp.ToString();
                    cbxLocalidad.SelectedValue = empleado.Localidad.IDlocalidad;
                    cbxPartido.SelectedValue = empleado.Localidad.IDpartido;
                    txbTelefonoPrincipal.Text = empleado.TelefonoPrincipal;
                    txbTelefonoAlternativo.Text = empleado.TelefonoSecundario;
                    dtpFechaNac.Value = empleado.FechaDeNacimiento;
                    txbNacionalidad.Text = empleado.Nacionalidad;
                    cbxEstadoCivil.SelectedValue = empleado.EstadoCivil.IdEstadoCivil;
                    nudHijos.Value = empleado.Hijos;
                    txbBasico.Text = empleado.Basico.ToString();
                    txbFoto.Text = empleado.Foto;

                    if (empleado.Sexo == 'M')
                    {
                        rdbMasculino.Checked = true;
                        pbxFoto.Image = Properties.Resources.Masculino;
                    }
                    else
                    {
                        rdbFemenino.Checked = true;
                        pbxFoto.Image = Properties.Resources.Femenino;
                    }
                    if (txbFoto.Text != "") pbxFoto.Image = Bitmap.FromFile(txbFoto.Text);
                    lblAltaUsuario.Text += empleado.UsuarioCreacion.Nombre;
                    lblAltaFecha.Text += empleado.FechaCreacion.ToShortDateString();
                    lblUsuarioModificacion.Text += empleado.UsuarioModificacion.Nombre;
                    if (empleado.FechaModificacion.ToString() != "1/1/0001 00:00:00") lblFechaModificacion.Text += empleado.FechaModificacion.ToShortDateString();
                    if (empleado.ControlHorario == true) rdbSi.Checked = true;
                    else rdbNo.Checked = false;
                    lblAltaUsuario.Show();
                    lblAltaFecha.Show();
                    lblUsuarioModificacion.Show();
                    lblFechaModificacion.Show();
                }

                else
                {

                    cbxConcepto.Text = "";
                    cbxCategoria.Text = "";
                    cbxContrato.Text = "";
                    cbxSeccion.Text = "";
                    cbxConvenio.Text = "";
                    cbxEstadoCivil.Text = "";
                    cbxLocalidad.Text = "";
                    cbxPartido.Text = "";
                    dtpFechaAlta.Value = DateTime.Today.AddDays(1);

                    if (dtpFechaAlta.Value.DayOfWeek.ToString() == "Saturday")
                    {
                        dtpFechaAlta.Value = DateTime.Today.AddDays(3);
                    }
                    else if (dtpFechaAlta.Value.DayOfWeek.ToString() == "Sunday")
                    {
                        dtpFechaAlta.Value = DateTime.Today.AddDays(2);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            //SE INICIA CON EL DIA DE ALTA POSTERIOR AL DE LA CARGA, SI ES FINDE SE CORRE AL LUNES.

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoPersonal empleadoPersonal = new EmpleadoPersonal();

            if (ValidarTextBoxsVacios())
            {
                try
                {
                    if (empleado == null) empleado = new Empleado();
                    else
                    {
                        empleado.UsuarioModificacion.ID = usuarioLogueado.ID;
                        empleado.FechaModificacion = DateTime.Now;
                    }

                    empleado.FechaAlta = dtpFechaAlta.Value.Date;
                    empleado.Contrato = new Contrato
                    {
                        Idcontrato = Convert.ToInt64(cbxContrato.SelectedValue),
                        Descripcion = cbxContrato.DisplayMember
                    };
                    empleado.Sexo = rdbMasculino.Checked ? 'M' : 'F';
                    empleado.Seccion = new Seccion
                    {
                        Idseccion = Convert.ToInt64(cbxSeccion.SelectedValue),
                        Nombre = cbxSeccion.DisplayMember
                    };
                    empleado.Concepto = new Concepto
                    {
                        IdConcepto = Convert.ToInt64(cbxConcepto.SelectedValue),
                        Nombre = cbxConcepto.DisplayMember
                    };
                    empleado.Convenio = new Convenio
                    {
                        IDconvenio = Convert.ToInt64(cbxConvenio.SelectedValue),
                        Descripcion = cbxConvenio.DisplayMember
                    };
                    empleado.Categoria = new Categoria
                    {
                        Idcategoria = Convert.ToInt64(cbxCategoria.SelectedValue),
                        nombre = cbxCategoria.DisplayMember
                    };
                    empleado.Nombre = txbNombre.Text.Trim();
                    empleado.Apellido = txbApellido.Text.Trim();
                    empleado.FechaDeNacimiento = dtpFechaNac.Value.Date;
                    empleado.Dni = txbDni.Text;
                    empleado.Cuil = txbCuil.Text;
                    empleado.ObraSocial = txbObraSocial.Text.Trim();
                    empleado.TelefonoPrincipal = txbTelefonoPrincipal.Text.Trim();
                    empleado.TelefonoSecundario = txbTelefonoAlternativo.Text.Trim();
                    empleado.Nacionalidad = txbNacionalidad.Text.Trim();
                    empleado.EstadoCivil = new EstadoCivil
                    {
                        IdEstadoCivil = Convert.ToByte(cbxEstadoCivil.SelectedValue),
                        Descripcion = cbxEstadoCivil.DisplayMember
                    };
                    empleado.Hijos = Convert.ToByte(nudHijos.Value.ToString());
                    empleado.Domicilio = txbDomicilio.Text.Trim();
                    empleado.Entrecalle1 = txbEntrecalles1.Text.Trim();
                    empleado.Entrecalle2 = txbEntrecalles2.Text.Trim();
                    empleado.Localidad = new Localidad
                    {
                        cp = Int64.Parse(txbCP.Text.Trim()),
                        IDlocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue)
                    };
                    empleado.Basico = Convert.ToDecimal(txbBasico.Text.Trim());
                    empleado.ControlHorario = rdbSi.Checked ? true : false;
                    empleado.UsuarioCreacion = new Usuario
                    {
                        ID = usuarioLogueado.ID
                    };
                    empleado.FechaCreacion = DateTime.Now;
                    if (cbxContrato.SelectedItem.ToString() == "TIEMPO INDETERMINADO")
                        empleado.VencimientoPrueba = dtpFechaAlta.Value.AddMonths(3);
                    if (cbxContrato.SelectedItem.ToString() == "TIEMPO DETERMINADO")
                        empleado.VencimientoPrueba = dtpFechaFinaliza.Value;
                    empleado.Foto = txbFoto.Text;
                    if (txbFoto.Text != "")
                    {
                        string destino = Path.Combine(Application.StartupPath, string.Format("c:\\PRUEBA\\{0}", Path.GetFileName(txbFoto.Text))); //TODO: Cambiar al directorio real de las fotos
                        if (txbFoto.Text != destino) File.Copy(txbFoto.Text, destino);
                        empleado.Foto = destino;
                    }


                    if (empleado.IDregistro != 0) empleadoPersonal.modificar(empleado);

                    else
                    {
                        empleadoPersonal.alta(empleado);
                        frmCorrecto ok = new frmCorrecto();
                        ok.ShowDialog();

                        VaciarTextBoxs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void CbxContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxConvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxbCP_Validated(object sender, EventArgs e)
        {

            try
            {
                if (completo)
                {
                    if (txbCP.Text == "")
                    {
                        CargarLocalidad();
                        CargarPartido();
                    }

                    else
                    {
                        LocalidadPersonal aux = new LocalidadPersonal();
                        Localidad aux2 = new Localidad();
                        CargarLocalidad(Int64.Parse(txbCP.Text));
                        Int64 ID = Convert.ToInt64(cbxLocalidad.SelectedValue);
                        aux2 = aux.buscarIDpartido(ID);
                        CargarPartido(aux2.IDpartido);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void CargarLocalidad(Int64 cp = 0)
        {
            LocalidadPersonal localidades;

            try
            {
                localidades = new LocalidadPersonal();

                if (cp == 0)
                {
                    cbxLocalidad.DataSource = localidades.listar();
                    cbxLocalidad.ValueMember = "IDlocalidad";
                    cbxLocalidad.DisplayMember = "nombre";
                    cbxLocalidad.Text = "";
                }

                else
                {
                    cbxLocalidad.DataSource = localidades.listar(Int64.Parse(txbCP.Text));
                    cbxLocalidad.ValueMember = "IDlocalidad";
                    cbxLocalidad.DisplayMember = "nombre";
                    cbxLocalidad.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarPartido(Int64 ID = 0)
        {
            PartidoPersonal partidos;

            try
            {
                partidos = new PartidoPersonal();

                if (ID == 0)
                {
                    cbxPartido.DataSource = partidos.listar();
                    cbxPartido.ValueMember = "IDpartido";
                    cbxPartido.DisplayMember = "nombre";
                    cbxPartido.Text = "";
                }
                else
                {
                    cbxPartido.DataSource = partidos.listar(ID);
                    cbxPartido.ValueMember = "IDpartido";
                    cbxPartido.DisplayMember = "nombre";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (completo)
                {
                    LocalidadPersonal aux = new LocalidadPersonal();
                    Localidad aux2 = new Localidad();
                    Int64 ID = Convert.ToInt64(cbxLocalidad.SelectedValue);
                    aux2 = aux.buscarIDpartido(ID);
                    txbCP.Text = aux2.cp.ToString();
                    CargarPartido(aux2.IDpartido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void VaciarTextBoxs()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    else if (item is RichTextBox)
                    {
                        item.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            try
            {
                cbxCategoria.SelectedIndex = -1;
                cbxConcepto.SelectedIndex = -1;
                cbxContrato.SelectedIndex = -1;
                cbxConvenio.SelectedIndex = -1;
                cbxEstadoCivil.SelectedIndex = -1;
                cbxLocalidad.SelectedIndex = -1;
                cbxPartido.SelectedIndex = -1;
                cbxSeccion.SelectedIndex = -1;
                rdbFemenino.Checked = false;
                rdbMasculino.Checked = false;
                rdbNo.Checked = false;
                rdbSi.Checked = false;
                dtpFechaNac.Value = DateTime.Now;
                pbxFoto.Image = Properties.Resources.usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        bool ValidarTextBoxsVacios()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        //Codigo comprobacion  de textbox
                        if (item.Text == "")
                        {
                            MessageBox.Show("Hay campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                    else if (item is RichTextBox)
                    {
                        //codigo comprobacion de richtextbox
                        if (item.Text == "")
                        {
                            MessageBox.Show("Hay campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                    else if (item is ComboBox)
                    {
                        if (item.Text == "")
                        {
                            MessageBox.Show("Debes seleccionar un item");
                            item.Focus();
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return true;
        }

        private void TxbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TxbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TxbCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TxbTelefonoPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TxbTelefonoAlternativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //    if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Divide))
                e.Handled = true;
        }

        private void TxbObraSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void TxbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void TxbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void TxbDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void TxbEntrecalles1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void TxbEntrecalles2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void CbxLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void CbxPartido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void TxbNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void CbxContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxContrato.SelectedItem.ToString() == "TIEMPO INDETERMINADO")
                {
                    lblFechaContrato.Visible = false;
                    dtpFechaFinaliza.Visible = false;
                }
                if (cbxContrato.SelectedItem.ToString() == "TIEMPO DETERMINADO")
                {
                    lblFechaContrato.Visible = true;
                    dtpFechaFinaliza.Visible = true;
                }

            }
            catch (Exception)
            {
            }
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF(*.gif)|*.gif"
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                pbxFoto.ImageLocation = file.FileName;
                txbFoto.Text = file.FileName;
            }
        }

        private void TxbBasico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
                e.Handled = true;
        }

        private void FrmAltaEmpleado_Shown(object sender, EventArgs e)
        {
            completo = true;
        }

        private void cbxSeccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ConceptoPersonal concepto;
            try
            {
                concepto = new ConceptoPersonal();
                cbxConcepto.DataSource = concepto.listar(((Seccion)cbxSeccion.SelectedItem).Idseccion);
                cbxConcepto.SelectedIndex = -1;
                cbxCategoria.DataSource = null;
                cbxCategoria.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxConcepto_SelectionChangeCommitted(object sender, EventArgs e)
        {

            CategoriaPersonal categoria;
            try
            {
                categoria = new CategoriaPersonal();
                cbxCategoria.DataSource = categoria.listar(((Concepto)cbxConcepto.SelectedItem).IdConcepto);
                cbxCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxSeccion.SelectedValue = 3;
        }

        private void cbxCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxConcepto.SelectedValue = ((Categoria)cbxCategoria.SelectedItem).IdConcepto;
            cbxSeccion.SelectedValue = ((Concepto)cbxConcepto.SelectedItem).IdArea;
        }
    }
}

