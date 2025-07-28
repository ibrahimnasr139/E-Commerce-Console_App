namespace Ecommerce_System_.Project
{
    internal class shippingProduct : IShippable
    {
        public double Weight { get;}
        public decimal Shippingfees { get;}
        public shippingProduct(double weight , decimal shippingfees)
        {
            this.Weight = weight;
            this.Shippingfees = shippingfees;
        }
        public double getWeight() => Weight;

    }
}
