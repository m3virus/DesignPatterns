using Core.Models.Product;

namespace Core.Models;

public class Order
{
    public List<ProductBase> Product { get; set; } = new ();
    public decimal TotalPrice { get; set; }
    public string ShippingAddress { get; set; }
    public string PaymentMethod { get; set; }
    public string CouponCode { get; set; }
    public override string ToString()
    {
        return $"Order with {Product.Count} items, Total: {TotalPrice:C}, Payment: {PaymentMethod}, Address: {ShippingAddress} ";
    }
}