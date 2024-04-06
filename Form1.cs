using ClosedXML.Excel;
using NLog;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class Form1 : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialogExcelSheet.ShowDialog() == DialogResult.OK)
                ReadSpreadSheetToGrid();
             
        }

        private void ReadSpreadSheetToGrid()
        {
            try
            {
                var workbook = new XLWorkbook(openFileDialogExcelSheet.FileName);
                var worksheet = workbook.Worksheets.First();
                var dataTable = new DataTable();

                // Add columns based on the first row (header row)
                foreach (var headerCell in worksheet.Row(1).Cells())
                {
                    dataTable.Columns.Add(headerCell.Value.ToString(), typeof(string));
                }

                // Add data rows from the worksheet (skip the header row)
                for (int row = 2; row <= worksheet.Rows().Count(); row++)
                {
                    var dataRow = dataTable.NewRow();
                    for (int col = 1; col <= worksheet.Columns().Count(); col++)
                    {
                        dataRow[col - 1] = worksheet.Cell(row, col).Value.ToString();
                    }
                    dataTable.Rows.Add(dataRow);
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                MessageBox.Show("Extension 'sql' is not supported. " +
                    "Supported extensions are '.xlsx', '.xlsm', '.xltx' and '.xltm'.");
            }
        }
    }
}
