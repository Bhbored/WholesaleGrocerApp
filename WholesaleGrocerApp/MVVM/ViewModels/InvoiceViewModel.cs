using System.Windows.Input;
using WholesaleGrocerApp.MVVM.Models.WholesaleGrocerApp.MVVM.Models;
using WholesaleGrocerApp.MVVM.Services;

namespace WholesaleGrocerApp.MVVM.ViewModels
{
    public class InvoiceViewModel
    {
        public InvoiceService? invoiceService;
        public Invoice? CurrentInvoice { get; set; }
        public ICommand? GeneratePdfCommand { get; }

        public Command? GoToProductsCommand { get; }
        public Command? GoToUsersCommand { get; }

        public INavigation _navigation;
        public InvoiceViewModel(INavigation navigation)
        {
            invoiceService = new InvoiceService();
            CurrentInvoice = new Invoice
            {
                ClientName = "Retail Client A",
                Products =
                [
                    new Product { Name = "Apples", Price = (double)2.5m, Quantity = 10 },
                    new Product { Name = "Bananas", Price = (double)1.2m, Quantity = 8 }
                ]
            };
            _navigation = navigation;
        }
    }
}
