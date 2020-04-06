using System;
using System.IO;

namespace HtmlToPdfNeedLandscapeFromCss
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToview = Path.Combine(Environment.CurrentDirectory, "FinalReport.cshtml");
            var htmlWithoutModelForNow = System.IO.File.ReadAllText(pathToview);

            var Renderer = new IronPdf.HtmlToPdf();
            var outputPath = Path.Combine(Environment.CurrentDirectory, "output.pdf");
            var pdfDoc = Renderer.RenderHtmlAsPdf(htmlWithoutModelForNow).SaveAs(outputPath);

        }
    }
}
