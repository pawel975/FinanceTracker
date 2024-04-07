
using System.Configuration;
using System;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;
using ClosedXML.Excel;
using System.Windows.Forms;

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
                        page.Margin(1, Unit.Centimetre);
                        page.DefaultTextStyle(ds => ds.FontSize(12));

                        page.Header()
                            .AlignCenter()
                            .Text("Raport Finansowy \n" + DateTime.Now.ToString("dd.MM.yyyy"))
                            .SemiBold().FontSize(20);

                        page.Content()
                            .Shrink()
                            .PaddingVertical(1, Unit.Centimetre)
                            .Table(table =>
                            {
                                DataTable dataTable = dataSet.Tables["aktywa"];

                                table.ColumnsDefinition(columns =>
                                {
                                    for (int c = 0; c < dataTable.Rows[0].Table.Columns.Count; c++)
                                        columns.RelativeColumn();
                                });

                                IContainer HeaderCellStyle(IContainer headerCellContainer)
                                {
                                    return headerCellContainer
                                        .Border(.1F)
                                        .Background(Colors.Grey.Lighten3)
                                        .Padding(2, Unit.Millimetre);
                                }

                                IContainer TableCellStyle(IContainer tableCellContainer)
                                {
                                    return tableCellContainer
                                        .Border(.1F)
                                        .Background(Colors.White)
                                        .Padding(2, Unit.Millimetre);
                                }

                                table.Header(header =>
                                {
                                    foreach (var headerCol in dataTable.Columns)
                                        header.Cell().Element(HeaderCellStyle).Text(headerCol.ToString());
                                });

                                for (int r = 0; r < dataTable.Rows.Count; r++)
                                {
                                    for (int c = 0; c < dataTable.Columns.Count; c++)
                                    {
                                        var cellVal = dataTable.Rows[r].Field<string>(c);

                                        table.Cell().Row((uint)r + 1).Column((uint)c + 1).Element(TableCellStyle).Text(cellVal.ToString());

                                    }
                                }
                            });
                    });


                }).GeneratePdf("../../test.pdf");

                System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["pdfFilePath"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Cannot generate document");
                _logger.Error(ex);
            }
        }
    }
}
