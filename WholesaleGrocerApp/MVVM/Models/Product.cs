namespace WholesaleGrocerApp.MVVM.Models
{
    namespace WholesaleGrocerApp.MVVM.Models
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }      // Price per unit
            public int Quantity { get; set; }      // Current quantity in stock

            // Optional: barcode or SKU for scanning
            public string Barcode { get; set; }
        }
    }

}
