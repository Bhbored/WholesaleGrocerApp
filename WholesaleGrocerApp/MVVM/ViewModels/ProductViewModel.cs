using System.Collections.ObjectModel;
using WholesaleGrocerApp.MVVM.Models.WholesaleGrocerApp.MVVM.Models;

namespace WholesaleGrocerApp.MVVM.ViewModels
{
    public class ProductViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductViewModel(User selectedUser)
        {
            // Dummy products for the example
            Products =
            [
                new() { Name = "Apple", Price = 2.5, Quantity = 10 },
                new() { Name = "Banana", Price = 1.2, Quantity = 5 }
            ];


        }

    }
}
