
namespace Ecommerce_System_.Project
{
    internal static class Stock
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product
                {
                    Name = "Cheese",
                    Price = 10m,
                    Quantity = 10,
                    expirable = new ExpiredProduct(new DateTime(2025,8,10)),
                    shippable = new shippingProduct(100,15m)
                },
            new Product
                {
                    Name = "Mobile",
                    Price = 100m,
                    Quantity = 10,
                    shippable = new shippingProduct(650,15m)
                },
            new Product
                {
                    Name = "Scratch Cards",
                    Price = 7m,
                    Quantity = 10,
                },
            new Product
                {
                    Name = "Laptop",
                    Price = 150m,
                    Quantity = 10,
                    shippable = new shippingProduct(2000,15m)
                },
            new Product
                {
                    Name = "TV",
                    Price = 200m,
                    Quantity = 10,
                    shippable = new shippingProduct(5000, 15m)
                },
            new Product
                {
                    Name = "Biscuits",
                    Price = 15m,
                    Quantity = 10,
                    expirable = new ExpiredProduct(new DateTime(2025,8,10)),
                    shippable = new shippingProduct(10,15m)
                }
        };
        public static List<Product> AllProducts() => _products;
    }
}
