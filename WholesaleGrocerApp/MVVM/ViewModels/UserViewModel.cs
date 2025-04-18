using System.Collections.ObjectModel;
using WholesaleGrocerApp.MVVM.Models.WholesaleGrocerApp.MVVM.Models;

namespace WholesaleGrocerApp.MVVM.ViewModels
{
    public class UserViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public UserViewModel()
        {
            Users =
            [
                new() { Name = "Sailor One" },
                new() { Name = "Sailor Two" },
                new() { Name = "Sailor Three" }
            ];
        }
    }
}
