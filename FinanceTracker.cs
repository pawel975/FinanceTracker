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
        public FinanceTracker()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            InitializeComponent();
        }

        private void buttonOpenExcelFileClick(object sender, EventArgs e)
        {
            if (openFileDialogExcelSheet.ShowDialog() == DialogResult.OK)
                ReadSpreadSheetToGrid();
        }

        private void buttonGeneratePDFReportClick(object sender, EventArgs e)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Header()
                        .Text("text");
                });
            }).GeneratePdf("../../test.pdf");

            System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["pdfFilePath"]);
            
        }
    }
}
