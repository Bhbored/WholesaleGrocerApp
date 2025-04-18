using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using WholesaleGrocerApp.MVVM.Models.WholesaleGrocerApp.MVVM.Models;

namespace WholesaleGrocerApp.MVVM.Services
{
    public class InvoiceService
    {
        public static async Task GenerateInvoicePdfAsync(Invoice invoice)
        {
            PdfDocument document = new();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;

            PdfFont headerFont = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
            PdfFont contentFont = new PdfStandardFont(PdfFontFamily.Helvetica, 10);

            graphics.DrawString($"Invoice for {invoice.ClientName}", headerFont, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 0));

            int y = 40;
            foreach (var product in invoice.Products)
            {
                string line = $"{product.Name} - {product.Price:C} - Qty: {product.Quantity}";
                graphics.DrawString(line, contentFont, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, y));
                y += 20;
            }

            graphics.DrawString($"Total: {invoice.TotalAmount:C}", headerFont, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, y));

            string filePath = Path.Combine(FileSystem.Current.AppDataDirectory, "invoice.pdf");
            document.Save(filePath);
            document.Close(true);

            await Launcher.Default.OpenAsync(new OpenFileRequest
            {
                File = new ReadOnlyFile(filePath)
            });
        }
    }
}