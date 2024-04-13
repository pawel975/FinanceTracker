using ClosedXML.Excel;
using NLog;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class FinanceTracker : Form
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        readonly DataSet dataSet = new DataSet();

        public FinanceTracker()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            InitializeComponent();
            buttonGeneratePDFReport.Enabled = false;
        }

        private void buttonOpenExcelFileClick(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogExcelSheet.ShowDialog() == DialogResult.OK)
                {
                    dataSet.Tables.Add(ReadSpreadSheetCells("B2", "D13", openFileDialogExcelSheet.FileName, "aktywa"));
                    buttonGeneratePDFReport.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
        }

        private void buttonGeneratePDFReportClick(object sender, EventArgs e)
        {
                GeneratePDFReport();
        }
    }
}
