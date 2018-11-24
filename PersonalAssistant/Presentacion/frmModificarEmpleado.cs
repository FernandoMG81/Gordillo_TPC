using System;
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
using Microsoft.Office.Interop.Excel;


namespace Presentacion
{
    public partial class frmModificarEmpleado : Form
    {
        private Usuario usuario;
        private string solapa = "ACTIVOS";

        public string ComentarioBaja { get; set; }
        public DateTime FechaBaja { get; set; }
        public List<Empleado> ListaActivos { get; set; }
        public List<Empleado> ListaBajas { get; set; }
        public List<Empleado> ListaLegajos { get; set; }

        public frmModificarEmpleado(Usuario user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            EmpleadoPersonal listaActivos, listaBajas, listaLegajos;

            try
            {
                listaActivos = new EmpleadoPersonal();
                listaBajas = new EmpleadoPersonal();
                listaLegajos = new EmpleadoPersonal();
                ListaActivos = (List<Empleado>)listaActivos.listar(false);
                ListaBajas = (List<Empleado>)listaBajas.listar(true);
                ListaLegajos = (List<Empleado>)listaLegajos.listarLegajosPendientes();

                dgvEmpleadosActivos.DataSource = ListaActivos;
                dgvEmpleadosActivos.Columns["baja"].Visible = false;
                dgvEmpleadosActivos.Columns["bajaMotivo"].Visible = false;
                dgvEmpleadosActivos.Columns["bajaFecha"].Visible = false;
                dgvEmpleadosActivos.Columns["idRegistro"].Visible = false;
                dgvEmpleadosActivos.Columns["Legajo"].DisplayIndex = 0;

                dgvEmpleadosBaja.DataSource = ListaBajas;
                dgvEmpleadosBaja.Columns["baja"].Visible = false;
                dgvEmpleadosBaja.Columns["idRegistro"].Visible = false;

                dgvLegajos.DataSource = ListaLegajos;
                dgvLegajos.Columns["idRegistro"].Visible = false;
                dgvLegajos.Columns["Nombre"].ReadOnly = true;
                dgvLegajos.Columns["apellido"].ReadOnly = true;
                // dgvLegajos.Columns["fechaAlta"].HeaderText = "Fecha de alta";
                dgvLegajos.Columns["fechaAlta"].ReadOnly = true;
                // dgvLegajos.Columns["VencimientoPrueba"].HeaderText = "Vencimiento Periodo de Prueba";
                dgvLegajos.Columns["VencimientoPrueba"].ReadOnly = true;
                dgvLegajos.Columns["dni"].ReadOnly = true;
                dgvLegajos.Columns["sexo"].Visible = false;
                dgvLegajos.Columns["contrato"].Visible = false;
                dgvLegajos.Columns["concepto"].Visible = false;
                dgvLegajos.Columns["seccion"].Visible = false;
                dgvLegajos.Columns["convenio"].Visible = false;
                dgvLegajos.Columns["categoria"].Visible = false;
                dgvLegajos.Columns["obraSocial"].Visible = false;
                dgvLegajos.Columns["fechaDeNacimiento"].Visible = false;
                dgvLegajos.Columns["cuil"].Visible = false;
                dgvLegajos.Columns["telefonoPrincipal"].Visible = false;
                dgvLegajos.Columns["telefonoSecundario"].Visible = false;
                dgvLegajos.Columns["nacionalidad"].Visible = false;
                dgvLegajos.Columns["estadoCivil"].Visible = false;
                dgvLegajos.Columns["hijos"].Visible = false;
                dgvLegajos.Columns["domicilio"].Visible = false;
                dgvLegajos.Columns["entreCalle1"].Visible = false;
                dgvLegajos.Columns["entreCalle2"].Visible = false;
                dgvLegajos.Columns["localidad"].Visible = false;
                dgvLegajos.Columns["basico"].Visible = false;
                dgvLegajos.Columns["edad"].Visible = false;
                dgvLegajos.Columns["baja"].Visible = false;
                dgvLegajos.Columns["Apellido"].DisplayIndex = 0;
                dgvLegajos.Columns["nombre"].DisplayIndex = 1;
                dgvLegajos.Columns["TelefonoAsignado"].Visible = false;
                dgvLegajos.Columns["ControlHorario"].Visible = false;
                dgvLegajos.Columns["FechaCreacion"].Visible = false;
                dgvLegajos.Columns["UsuarioCreacion"].Visible = false;
                dgvLegajos.Columns["FechaModificacion"].Visible = false;
                dgvLegajos.Columns["UsuarioModificacion"].Visible = false;
                dgvLegajos.Columns["bajaFecha"].Visible = false;
                dgvLegajos.Columns["bajaMotivo"].Visible = false;
                dgvLegajos.Columns["foto"].Visible = false;
                dgvLegajos.Columns["legajo"].DisplayIndex = 0;
                dgvLegajos.Columns["dni"].DisplayIndex = 1;
                dgvLegajos.Columns["nombre"].DisplayIndex = 2;
                dgvLegajos.Columns["apellido"].DisplayIndex = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EmpleadoPersonal empleado = new EmpleadoPersonal();
            Empleado modificar;

            try
            {

                modificar = (Empleado)dgvEmpleadosActivos.CurrentRow.DataBoundItem;
                //empleado.alta(modificar);
                frmAltaEmpleado modificado = new frmAltaEmpleado(modificar, usuario);
                modificado.ShowDialog();
                frmModificarEmpleado_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            EmpleadoPersonal baja;
            Empleado aux;
            frmComentarioBaja comentario;
            try
            {
                aux = new Empleado();
                baja = new EmpleadoPersonal();
                comentario = new frmComentarioBaja();
                AddOwnedForm(comentario);
                aux = (Empleado)dgvEmpleadosActivos.CurrentRow.DataBoundItem;
                aux.UsuarioModificacion.ID = usuario.ID;
                aux.FechaModificacion = DateTime.Now;
                comentario.ShowDialog();
                aux.BajaFecha = FechaBaja;
                aux.BajaMotivo = ComentarioBaja;
                baja.bajaLogica(aux);
                frmModificarEmpleado_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void TbcListadoEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcListadoEmpleados.SelectedIndex == 0)
            {
                btnBaja.Visible = true;
                btnModificar.Visible = true;
                lblNota.Visible = false;
                btnExcel.Visible = true;
                solapa = "ACTIVOS";
            }
            if (tbcListadoEmpleados.SelectedIndex == 1)
            {
                btnBaja.Visible = false;
                btnModificar.Visible = true;
                lblNota.Visible = false;
                btnExcel.Visible = true;
                solapa = "BAJAS";
            }
            if (tbcListadoEmpleados.SelectedIndex == 2)
            {
                btnBaja.Visible = false;
                btnModificar.Visible = false;
                lblNota.Visible = true;
                btnExcel.Visible = false;
            }
        }

        private void TxbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tbcListadoEmpleados.SelectedIndex == 0)
            {
                EmpleadoPersonal listaActivos = new EmpleadoPersonal();

                if (txbBuscar.Text == "")
                {
                    dgvEmpleadosActivos.DataSource = listaActivos.listar(false);
                }
                else
                {
                    if (cbxBuscar.Text == "Apellido")
                    {
                        List<Empleado> lista;
                        lista = ListaActivos.FindAll(LETRA => LETRA.Apellido.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvEmpleadosActivos.DataSource = lista;
                    }
                    else if (cbxBuscar.Text == "Nombre")
                    {
                        List<Empleado> lista;
                        lista = ListaActivos.FindAll(LETRA => LETRA.Nombre.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvEmpleadosActivos.DataSource = lista;
                    }
                }
            }

            if (tbcListadoEmpleados.SelectedIndex == 1)
            {
                EmpleadoPersonal listaBajas = new EmpleadoPersonal();

                if (txbBuscar.Text == "")
                {
                    dgvEmpleadosBaja.DataSource = listaBajas.listar(true);
                }
                else
                {
                    if (cbxBuscar.Text == "Apellido")
                    {
                        List<Empleado> lista;
                        lista = ListaBajas.FindAll(LETRA => LETRA.Apellido.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvEmpleadosBaja.DataSource = lista;
                    }
                    else if (cbxBuscar.Text == "Nombre")
                    {
                        List<Empleado> lista;
                        lista = ListaBajas.FindAll(LETRA => LETRA.Nombre.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvEmpleadosBaja.DataSource = lista;
                    }
                }
            }
            if (tbcListadoEmpleados.SelectedIndex == 2)
            {
                EmpleadoPersonal listaLegajo = new EmpleadoPersonal();

                if (txbBuscar.Text == "")
                {
                    dgvLegajos.DataSource = listaLegajo.listarLegajosPendientes();
                }
                else
                {
                    if (cbxBuscar.Text == "Apellido")
                    {
                        List<Empleado> lista;
                        lista = ListaLegajos.FindAll(LETRA => LETRA.Apellido.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvLegajos.DataSource = lista;
                    }
                    else if (cbxBuscar.Text == "Nombre")
                    {
                        List<Empleado> lista;
                        lista = ListaLegajos.FindAll(LETRA => LETRA.Nombre.ToLower().Contains(txbBuscar.Text.ToLower()));
                        dgvLegajos.DataSource = lista;
                    }
                }
            }


        }

        private void DgvLegajos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            EmpleadoPersonal legajo;
            try
            {
                legajo = new EmpleadoPersonal();
                legajo.modificarLegajo((Empleado)dgvLegajos.CurrentRow.DataBoundItem);
            }
            catch (Exception)
            {

                MessageBox.Show("El Número de legajo ya existe");
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog archivo = new SaveFileDialog
                {
                    Filter = "Excel (*.xls)|*.xls"
                };
                if (solapa == "ACTIVOS") archivo.FileName = "Reporte Empleados Activo" + DateTime.Now.Date.ToShortDateString().Replace('/', '-');
                else archivo.FileName = "Reporte Empleados Baja" + DateTime.Now.Date.ToShortDateString().Replace('/', '-');
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libroDeTrabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hojaDeTrabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libroDeTrabajo = aplicacion.Workbooks.Add();
                    hojaDeTrabajo = (Microsoft.Office.Interop.Excel.Worksheet)libroDeTrabajo.Worksheets.get_Item(1);

                    hojaDeTrabajo.Cells[1, "A"] = dgvEmpleadosActivos.Columns[0].HeaderText;
                    hojaDeTrabajo.Cells[1, "B"] = dgvEmpleadosActivos.Columns[1].HeaderText;
                    hojaDeTrabajo.Cells[1, "C"] = dgvEmpleadosActivos.Columns[2].HeaderText;
                    hojaDeTrabajo.Cells[1, "D"] = dgvEmpleadosActivos.Columns[3].HeaderText;
                    hojaDeTrabajo.Cells[1, "E"] = dgvEmpleadosActivos.Columns[4].HeaderText;
                    hojaDeTrabajo.Cells[1, "F"] = dgvEmpleadosActivos.Columns[5].HeaderText;
                    hojaDeTrabajo.Cells[1, "G"] = dgvEmpleadosActivos.Columns[6].HeaderText;
                    hojaDeTrabajo.Cells[1, "H"] = dgvEmpleadosActivos.Columns[7].HeaderText;
                    hojaDeTrabajo.Cells[1, "I"] = dgvEmpleadosActivos.Columns[8].HeaderText;
                    hojaDeTrabajo.Cells[1, "J"] = dgvEmpleadosActivos.Columns[9].HeaderText;
                    hojaDeTrabajo.Cells[1, "K"] = dgvEmpleadosActivos.Columns[10].HeaderText;
                    hojaDeTrabajo.Cells[1, "L"] = dgvEmpleadosActivos.Columns[11].HeaderText;
                    hojaDeTrabajo.Cells[1, "M"] = dgvEmpleadosActivos.Columns[12].HeaderText;
                    hojaDeTrabajo.Cells[1, "N"] = dgvEmpleadosActivos.Columns[13].HeaderText;
                    hojaDeTrabajo.Cells[1, "O"] = dgvEmpleadosActivos.Columns[14].HeaderText;
                    hojaDeTrabajo.Cells[1, "P"] = dgvEmpleadosActivos.Columns[15].HeaderText;
                    hojaDeTrabajo.Cells[1, "Q"] = dgvEmpleadosActivos.Columns[16].HeaderText;
                    hojaDeTrabajo.Cells[1, "R"] = dgvEmpleadosActivos.Columns[17].HeaderText;
                    hojaDeTrabajo.Cells[1, "S"] = dgvEmpleadosActivos.Columns[18].HeaderText;
                    hojaDeTrabajo.Cells[1, "T"] = dgvEmpleadosActivos.Columns[19].HeaderText;
                    hojaDeTrabajo.Cells[1, "U"] = dgvEmpleadosActivos.Columns[20].HeaderText;
                    hojaDeTrabajo.Cells[1, "V"] = dgvEmpleadosActivos.Columns[21].HeaderText;
                    hojaDeTrabajo.Cells[1, "W"] = dgvEmpleadosActivos.Columns[22].HeaderText;
                    hojaDeTrabajo.Cells[1, "X"] = dgvEmpleadosActivos.Columns[23].HeaderText;
                    hojaDeTrabajo.Cells[1, "Y"] = dgvEmpleadosActivos.Columns[24].HeaderText;
                    hojaDeTrabajo.Cells[1, "Z"] = dgvEmpleadosActivos.Columns[25].HeaderText;
                    hojaDeTrabajo.Cells[1, "AA"] = dgvEmpleadosActivos.Columns[26].HeaderText;
                    hojaDeTrabajo.Cells[1, "AB"] = dgvEmpleadosActivos.Columns[27].HeaderText;
                    hojaDeTrabajo.Cells[1, "AC"] = dgvEmpleadosActivos.Columns[28].HeaderText;
                    hojaDeTrabajo.Cells[1, "AD"] = dgvEmpleadosActivos.Columns[29].HeaderText;
                    hojaDeTrabajo.Cells[1, "AE"] = dgvEmpleadosActivos.Columns[30].HeaderText;
                    hojaDeTrabajo.Cells[1, "AF"] = dgvEmpleadosActivos.Columns[31].HeaderText;
                    hojaDeTrabajo.Cells[1, "AG"] = dgvEmpleadosActivos.Columns[32].HeaderText;
                    hojaDeTrabajo.Cells[1, "AH"] = dgvEmpleadosActivos.Columns[33].HeaderText;
                    hojaDeTrabajo.Cells[1, "AI"] = dgvEmpleadosActivos.Columns[34].HeaderText;
                    hojaDeTrabajo.Cells[1, "AJ"] = dgvEmpleadosActivos.Columns[35].HeaderText;
                    hojaDeTrabajo.Cells[1, "AK"] = dgvEmpleadosActivos.Columns[36].HeaderText;

                    //hojaDeTrabajo.Columns[1].Autofill();
                    //hojaDeTrabajo.Columns[2].AutoFill();
                    //hojaDeTrabajo.Columns[3].AutoFill();
                    //hojaDeTrabajo.Columns[4].AutoFill();
                    //hojaDeTrabajo.Columns[5].AutoFill();
                    //hojaDeTrabajo.Columns[6].AutoFill();
                    hojaDeTrabajo.Name = "Empleados";

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    if (solapa == "ACTIVOS")
                    {
                        for (int i = 0; i < dgvEmpleadosActivos.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvEmpleadosActivos.Columns.Count; j++)
                            {
                                if (dgvEmpleadosActivos.Rows[i].Cells[j].Value != null)
                                {
                                    hojaDeTrabajo.Cells[i + 2, j + 1] = dgvEmpleadosActivos.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                        }
                       //hojaDeTrabajo.Columns["A"].Delete();
                    }
                    else
                    {
                        for (int i = 0; i < dgvEmpleadosBaja.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvEmpleadosBaja.Columns.Count; j++)
                            {
                                if (dgvEmpleadosBaja.Rows[i].Cells[j].Value != null)
                                {
                                    hojaDeTrabajo.Cells[i + 2, j + 1] = dgvEmpleadosBaja.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                        }
                    }



                    libroDeTrabajo.SaveAs(archivo.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libroDeTrabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Empleados Exportado a Excel", "Personal Assistant");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
    }
}



