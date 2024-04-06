
using System.Configuration;
using System;
using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace FinanceTracker
{
    public partial class FinanceTracker
    {
        private void GeneratePDFReport()
        {
            try
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
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
        }
    }
}
