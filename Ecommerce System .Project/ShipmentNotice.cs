namespace Ecommerce_System_.Project
{
    internal static class ShipmentNotice
    {
        private static double TotalWeight = 0.0;
        public static bool shipmentNotice(Customer customer, Cart car)
        {
            // makesure the cart not empty
            if (car.CustomerCart.Count == 0)
            {
                Console.WriteLine("Sorry, there are no products in the cart.");
                return false;
            }

            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║         Welcome to E-Commerce Checkout         ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝\n");
            Console.WriteLine("╔═════════════════════════════════════════════════╗");
            Console.WriteLine("╚>                Shipment notice                <╝");
            Console.WriteLine("────────────────────────────────────────────────────");

            foreach (var cartItem in car.CustomerCart)
            {
                Product product = cartItem.Key;
                int quantity = cartItem.Value;

                // check product is expired or not
                if (product.expirable is IExpirable expirable && expirable.IsExpired())
                {
                    Console.WriteLine($"Product {product.Name} expired on {expirable.ExpiryDate}");
                    return false;
                }

                // check customer balance is enough to buy products 
                if (customer.Balance < product.Price * quantity)
                {
                    Console.WriteLine("Error: Customer's balance is insufficient!!!");
                    return false;
                }
                // check product is ReShippable
                if (product.shippable is IShippable shippable)
                {
                    Console.WriteLine($"{quantity}x \t{product.Name,-20} {shippable.getWeight()}g");
                    TotalWeight += shippable.getWeight() * quantity;
                }
            }

            Console.WriteLine($"Total package weight: {(TotalWeight > 1000 ? $"{Math.Round(TotalWeight / 1000, 2)} Kg" : $"{TotalWeight} g")}\n");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Shipment Verified. Proceeding to Payment...");
            Console.WriteLine();
            return true;
        }
    }
}
