namespace Ecommerce_System_.Project
{
    internal class CheckOut
    {
        private decimal SubTotal = 0.0m;
        private decimal Shipping = 0.0m;
        private decimal Amount = 0.0m;
        private decimal CurrentBalance = 0.0m;
        public void checkout(Customer customer, Cart car)
        {
            if (!ShipmentNotice.shipmentNotice(customer, car))
                return;

            Console.WriteLine("╔══════════════ Receipt ══════════════╗");
            Console.WriteLine("║ Qty         Product     Price       ║");
            Console.WriteLine("──────────────────────────────────────");

            foreach (var cartItem in car.CustomerCart)
            {
                Product product = cartItem.Key;
                int quantity = cartItem.Value;

                Console.WriteLine($"{quantity}x \t{product.Name}\t\t{product.Price.ToString("C")}$");
                SubTotal += product.Price * quantity;

                if (product.shippable is IShippable shippable)
                    Shipping += shippable.Shippingfees;
            }

            Amount = SubTotal + Shipping;
            CurrentBalance = customer.Balance - Amount;

            Console.WriteLine("──────────────────────────────────────");
            Console.WriteLine($"╚═> Customer's Balance:\t {customer.Balance.ToString("C")}$");
            Console.WriteLine($"╚═> SubTotal:\t\t {SubTotal.ToString("C")}$");
            Console.WriteLine($"╚═> Shipping:\t\t {Shipping.ToString("C")}$");
            Console.WriteLine($"╚═> Amount:\t\t {Amount.ToString("C")}$");
            Console.WriteLine($"╚═> Current Balance:\t {CurrentBalance.ToString("C")}$");
            Console.WriteLine("──────────────────────────────────────");
        }
    }
}
