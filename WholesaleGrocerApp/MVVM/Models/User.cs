namespace WholesaleGrocerApp.MVVM.Models
{
    namespace WholesaleGrocerApp.MVVM.Models
    {
        public class User
        {
            public string? Name { get; set; }
            public string? Id { get; set; }  // Unique ID if needed for database reference

            // Optional: contact, address, etc.
            public string? ContactNumber { get; set; }
        }
    }

}
