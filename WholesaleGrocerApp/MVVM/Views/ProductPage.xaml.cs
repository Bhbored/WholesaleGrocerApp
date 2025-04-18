
using WholesaleGrocerApp.MVVM.Models.WholesaleGrocerApp.MVVM.Models;
using WholesaleGrocerApp.MVVM.ViewModels;

namespace WholesaleGrocerApp.MVVM.Views;

public partial class ProductPage : ContentPage
{
    public User _selectedUser;

    public ProductPage(User user)
    {
        InitializeComponent();
        _selectedUser = user;
        BindingContext = new ProductViewModel(_selectedUser); // Pass user to ProductViewModel
    }
}