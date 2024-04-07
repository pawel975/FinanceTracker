using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class FinanceTracker
    {
        /// <summary>
        /// Creates new table from data in declared worksheet range and saves it to dataSet
        /// </summary>
        /// <param name="topLeft"></param>
        /// <param name="bottomRight"></param>
        /// <param name="newTableName"></param>
        private DataTable ReadSpreadSheetCells(string topLeft, string bottomRight, string excelFileName, [Optional] string newTableName)
        {
            DataTable dt = new DataTable(newTableName);

            try
            {
                var workbook = new XLWorkbook(excelFileName);
                var worksheet = workbook.Worksheets.First();

                IXLTable worksheetTable = worksheet.Range($"{topLeft}:{bottomRight}").CreateTable();

                // Read First Row of Excel Sheet to add Columns to DataTable
                worksheetTable.FirstRowUsed().CellsUsed().ToList()
                .ForEach(x => { dt.Columns.Add(x.Value.ToString()); });

                foreach (IXLRangeRow row in worksheetTable.RowsUsed().Skip(1))
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        dr[i] = row.Cell(i + 1).Value.ToString();
                    }
                    dt.Rows.Add(dr);
                }
                textBoxFileName.Text = excelFileName;

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Wrong file extension or broken file.");
                _logger.Error(ex);

                return null;
            }

        }
    }
}
