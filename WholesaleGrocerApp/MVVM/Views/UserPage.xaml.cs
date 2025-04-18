using WholesaleGrocerApp.MVVM.ViewModels;

namespace WholesaleGrocerApp.MVVM.Views;

[XamlCompilation(XamlCompilationOptions.Compile)] // Add this attribute to enable XAML compilation  
public partial class UserPage : ContentPage
{
    public UserPage()
    {
        InitializeComponent(); // Ensure the corresponding XAML file exists and is properly linked  
        BindingContext = new UserViewModel();
    }

}
