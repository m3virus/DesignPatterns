using Core.Models;
using Core.Models.Product;
using Core.Services;

//Builder pattern
namespace Application.OrderProcessing;

public class OrderBuilder:IOrderBuilder
{
    private Order _order = new();
    public void AddProduct(ProductBase product) => _order.Product.Add(product);
    public void SetShippingAddress(string address) => _order.ShippingAddress = address;
    public void SetPaymentMethod(string method) => _order.PaymentMethod = method;
    public void ApplyCoupon(string coupon, decimal discount) => _order.TotalPrice -= discount;
    public Order Build() => _order;
}