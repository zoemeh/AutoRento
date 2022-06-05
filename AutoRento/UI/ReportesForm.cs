using AutoRento.Data;
using AutoRento.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AutoRento.UI
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteExcel();
        }
        public void LoadData()
        {
            clientesCombo.DataSource = (new ClienteRepo()).View();
        }
        private void WriteExcel()
        {
            using AutoRentoContext db = new AutoRentoContext();
            var query = db.Rentas.Include(x => x.Empleado).Include(x => x.Vehiculo).Include(x => x.Cliente)
                .Where(x => x.FechaRenta >= desdeDate.Value && x.FechaRenta <= hastaDate.Value);
            if (!todosCheck.Checked)
            {
                query = query.Where(x => x.ClienteId == ((Cliente)clientesCombo.SelectedItem).Id);
            }
            var rentas = query.ToList();
            DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(rentas), (typeof(DataTable)));
            var memoryStream = new MemoryStream();

            using (var fs = new FileStream("Result.xlsx", FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("Sheet1");

                List<String> columns = new List<string>();
                IRow row = excelSheet.CreateRow(0);
                int columnIndex = 0;

                foreach (System.Data.DataColumn column in table.Columns)
                {
                    columns.Add(column.ColumnName);
                    row.CreateCell(columnIndex).SetCellValue(column.ColumnName);
                    columnIndex++;
                }

                int rowIndex = 1;
                foreach (DataRow dsrow in table.Rows)
                {
                    row = excelSheet.CreateRow(rowIndex);
                    int cellIndex = 0;
                    foreach (String col in columns)
                    {
                        row.CreateCell(cellIndex).SetCellValue(dsrow[col].ToString());
                        cellIndex++;
                    }

                    rowIndex++;
                }
                workbook.Write(fs);
                FileInfo fi = new FileInfo("Result.xlsx");
                if (fi.Exists)
                {
                    using Process fileopener = new Process();

                    fileopener.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft Office\root\Office16\excel.exe";
                    fileopener.StartInfo.Arguments = "\"" + "Result.xlsx" + "\"";
                    fileopener.Start();

                }
                else
                {
                    //file doesn't exist
                }
            }

        }
    }
}
