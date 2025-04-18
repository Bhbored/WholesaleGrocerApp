namespace WholesaleGrocerApp.MVVM.Models
{
    namespace WholesaleGrocerApp.MVVM.Models
    {
        public class Invoice
        {
            public string ClientName { get; set; }
            public List<Product> Products { get; set; } = [];

            public double TotalAmount
            {
                get
                {
                    double total = 0;
                    foreach (var product in Products)
                    {
                        total += product.Price * product.Quantity;
                    }
                    return total;
                }
            }
        }

    }
}
