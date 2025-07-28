namespace Ecommerce_System_.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>(Stock.AllProducts());
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║             All Product In Stock               ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            foreach (Product product in products)
            {
                Console.WriteLine($"║→ Name: {product.Name}\t\t" +
                                  $"Price: {product.Price.ToString("c")}\t\t" +
                                  $"Quantity: {product.Quantity}");
            }
            Console.WriteLine("════════════════════════════════════════════════════════════════════\n");

            Customer customer = new Customer(1000);

            Cart cart = new Cart();
            cart.AddProduct("Cheese",5);
            cart.AddProduct("Scratch Cards", 2);
            cart.AddProduct("TV", 2);
            cart.AddProduct("Computer", 10);

            CheckOut checkOut = new CheckOut();
            checkOut.checkout(customer, cart);
        }
    }
}
