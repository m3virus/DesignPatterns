#pragma warning disable SA1200
using Core.Models.Product;
#pragma warning restore SA1200

namespace Core.Models;

/// <summary>
/// A class for set a model for orders.
/// </summary>
public class Order
{
    /// <summary>
    /// Gets or sets list of products in orders.
    /// </summary>
    public List<ProductBase> Product { get; set; } = new ();

    /// <summary>
    /// Gets or sets total price of the order.
    /// </summary>
    public decimal TotalPrice { get; set; }

    /// <summary>
    /// Gets or sets the address for shipping.
    /// </summary>
    public string ShippingAddress { get; set; } = string.Empty;

    /// <summary>
    ///  Gets or sets the method for payment.
    /// </summary>
    public string PaymentMethod { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets coupon code for discount.
    /// </summary>
    public string CouponCode { get; set; } = string.Empty;

    /// <summary>
    /// نمایش اطلاعات سفارش به صورت رشته.
    /// </summary>
    /// <returns>رشته‌ای شامل تعداد محصولات، قیمت کل، روش پرداخت و آدرس ارسال.</returns>
    public override string ToString() =>
        $"Order with {this.Product.Count} items, Total: {this.TotalPrice:C}, Payment: {this.PaymentMethod}, Address: {this.ShippingAddress}";
}