
namespace Ecommerce_System_.Project
{
    internal class Cart
    {
        public Dictionary<Product, int> CustomerCart { get; set; } = new Dictionary<Product, int>();
        public void AddProduct(string name , int count)
        {
            foreach(Product product in Stock.AllProducts())
            {
                if (String.Equals(product.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    if (count > product.Quantity)
                    {
                        Console.WriteLine($" → Sorry, the quantity requested for the product [{name}] " +
                                          "is more than what is available in the stock ...");
                        Console.WriteLine($"\t\t\t\t\t\t  ╚═>  What is available for this product is [ {product.Quantity} ]");
                        return;
                    }
                    if (!CustomerCart.ContainsKey(product))
                        CustomerCart.Add(product, count);
                       
                    else
                        CustomerCart[product] += count;
                    Console.WriteLine($"Add product [{name}] ...");
                    Thread.Sleep(1000);
                    Console.WriteLine($" → The product [{name}] was added successfully.\n");
                    product.Quantity -= count;
                    return;  
                }
            }
            Console.WriteLine($"Add product [{name}]s ...");
            Thread.Sleep(1000);
            Console.WriteLine($" → Sorry, The product [{name}] Not available in stock !!\n");
        }
    }
}
