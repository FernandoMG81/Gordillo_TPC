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
using Microsoft.Office.Interop.Excel;

namespace Presentacion
{
    public partial class frmInformeHorario : Form
    {
        public frmInformeHorario()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            horarioPersonal informe;
            try
            {
                informe = new horarioPersonal();
                dtpDesde.Value = dtpDesde.Value.AddHours(-DateTime.Now.Hour);
                dtpDesde.Value = dtpDesde.Value.AddMinutes(-DateTime.Now.Minute);
                dtpHasta.Value = dtpHasta.Value.AddHours(23-DateTime.Now.Hour);
                dtpHasta.Value = dtpHasta.Value.AddMinutes(59-DateTime.Now.Minute);
                dgvInforme.DataSource = informe.listarInforme(dtpDesde.Value, dtpHasta.Value, cbxEmpleados.SelectedValue.ToString());
                dgvInforme.Columns["idregistro"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog archivo = new SaveFileDialog();
                archivo.Filter = "Excel (*.xls)|*.xls";
                archivo.FileName = "Reporte Horario" + DateTime.Now.Date.ToShortDateString().Replace('/', '-');
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libroDeTrabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hojaDeTrabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libroDeTrabajo = aplicacion.Workbooks.Add();
                    hojaDeTrabajo = (Microsoft.Office.Interop.Excel.Worksheet)libroDeTrabajo.Worksheets.get_Item(1);

                    hojaDeTrabajo.Cells[1, "A"] = dgvInforme.Columns[0].HeaderText;
                    hojaDeTrabajo.Cells[1, "B"] = dgvInforme.Columns[1].HeaderText;
                    hojaDeTrabajo.Cells[1, "C"] = dgvInforme.Columns[2].HeaderText;
                    hojaDeTrabajo.Cells[1, "D"] = dgvInforme.Columns[3].HeaderText;
                    hojaDeTrabajo.Cells[1, "E"] = dgvInforme.Columns[4].HeaderText;
                    hojaDeTrabajo.Cells[1, "F"] = dgvInforme.Columns[5].HeaderText;
                    hojaDeTrabajo.Cells[1, "G"] = dgvInforme.Columns[6].HeaderText;

                    
                    //hojaDeTrabajo.Columns[1].Autofill();
                    //hojaDeTrabajo.Columns[2].AutoFill();
                    //hojaDeTrabajo.Columns[3].AutoFill();
                    //hojaDeTrabajo.Columns[4].AutoFill();
                    //hojaDeTrabajo.Columns[5].AutoFill();
                    //hojaDeTrabajo.Columns[6].AutoFill();
                    hojaDeTrabajo.Name = "Registro";
                    
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dgvInforme.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvInforme.Columns.Count; j++)
                        {
                            if (dgvInforme.Rows[i].Cells[j].Value != null)
                            {
                                hojaDeTrabajo.Cells[i + 2, j + 1] = dgvInforme.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    hojaDeTrabajo.Columns["A"].Delete();

                    libroDeTrabajo.SaveAs(archivo.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libroDeTrabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Horario Exportado a Excel", "Personal Assistant");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }

        private void frmInformeHorario_Load(object sender, EventArgs e)
        {
            EmpleadoPersonal emp;
            Empleado aux;
            try
            {
                emp = new EmpleadoPersonal();
                aux = new Empleado();
                cbxEmpleados.DataSource = emp.listarDepositoInforme();
                cbxEmpleados.DisplayMember = "Nombre";
                cbxEmpleados.ValueMember = "dni";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

