using Core.Models;
using Core.Models.Product;

namespace Core.Services;

public interface IOrderBuilder
{
    void AddProduct(ProductBase product);
    void SetShippingAddress(string address);
    void SetPaymentMethod(string method);
    void ApplyCoupon(string coupon, decimal discount);
    Order Build();
}