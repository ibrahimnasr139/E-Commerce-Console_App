
namespace Ecommerce_System_.Project
{
    internal class ExpiredProduct : IExpirable
    {
        public DateTime ExpiryDate { get; }
        public ExpiredProduct(DateTime date)
        {
            this.ExpiryDate = date;
        }
        public bool IsExpired() => DateTime.Now >= ExpiryDate;
    }
}
