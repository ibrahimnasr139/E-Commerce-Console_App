
namespace Ecommerce_System_.Project
{
    internal class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }
        public IShippable? shippable { get; set; }
        public IExpirable? expirable { get; set; }
        public override bool Equals(object? obj)
        {
            Product? other = obj as Product;
            if (other is not null)
                return this.Name.Equals(other.Name,StringComparison.OrdinalIgnoreCase);
            return false;
        }
        public override int GetHashCode() => StringComparer.OrdinalIgnoreCase.GetHashCode(Name);
    }

}
