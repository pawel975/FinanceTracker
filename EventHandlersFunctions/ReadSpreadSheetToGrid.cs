using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class FinanceTracker
    {
        DataTable DataTable { get; set; } = new DataTable();
        private void ReadSpreadSheetToGrid()
        {
            try
            {
                var workbook = new XLWorkbook(openFileDialogExcelSheet.FileName);
                var worksheet = workbook.Worksheets.First();
                //var dataTable = new DataTable();

                // Add columns based on the first row (header row)
                foreach (var headerCell in worksheet.Row(1).Cells())
                {
                    DataTable.Columns.Add(headerCell.Value.ToString(), typeof(string));
                }

                // Add data rows from the worksheet (skip the header row)
                for (int row = 2; row <= worksheet.Rows().Count(); row++)
                {
                    var dataRow = DataTable.NewRow();
                    for (int col = 1; col <= worksheet.Columns().Count(); col++)
                    {
                        dataRow[col - 1] = worksheet.Cell(row, col).Value.ToString();
                    }
                    DataTable.Rows.Add(dataRow);
                }

                dataGridView1.DataSource = DataTable;
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
