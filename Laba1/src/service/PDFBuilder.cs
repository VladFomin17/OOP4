using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace Laba1.service;

public class PDFBuilder
{
    public static string BuildPDFReport(string report)
    {
        QuestPDF.Settings.License = LicenseType.Community;
        
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Report.pdf");

        Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Size(PageSizes.A4);
                    page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Arial"));

                    page.Header().Text("Отчет ЖЭК").FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                    page.Content().PaddingVertical(10).Column(col =>
                    {
                        col.Item().Text(report);
                    });

                    page.Footer().AlignCenter().Text(x => x.CurrentPageNumber());
                });
            })
            .GeneratePdf(filePath);

        return filePath;
    }
}