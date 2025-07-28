
namespace Ecommerce_System_.Project
{
    interface IExpirable
    {
        DateTime ExpiryDate { get; }
        bool IsExpired();
    }
}
