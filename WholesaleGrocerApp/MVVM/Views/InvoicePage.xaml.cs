using WholesaleGrocerApp.MVVM.ViewModels;

namespace WholesaleGrocerApp.MVVM.Views;

public partial class InvoicePage : ContentPage
{
    public InvoicePage()
    {
        InitializeComponent();
        BindingContext = new InvoiceViewModel(Navigation);
    }
}