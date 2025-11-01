using Core.Models.Product;

namespace Core.Models;

/// <summary>
/// نمایانگر یک سفارش شامل محصولات، اطلاعات پرداخت و ارسال.
/// </summary>
public class Order
{
    /// <summary>
    /// Gets or sets list of products in orders
    /// </summary>
    public List<ProductBase> Product { get; set; } = new ();

    /// <summary>
    /// مجموع قیمت کل سفارش.
    /// </summary>
    public decimal TotalPrice { get; set; }

    /// <summary>
    /// آدرس ارسال سفارش.
    /// </summary>
    public string ShippingAddress { get; set; }

    /// <summary>
    /// روش پرداخت سفارش (مانند کارت، نقدی یا آنلاین).
    /// </summary>
    public string PaymentMethod { get; set; }

    /// <summary>
    /// کد تخفیف اعمال شده روی سفارش، در صورت وجود.
    /// </summary>
    public string CouponCode { get; set; }

    /// <summary>
    /// نمایش اطلاعات سفارش به صورت رشته.
    /// </summary>
    /// <returns>رشته‌ای شامل تعداد محصولات، قیمت کل، روش پرداخت و آدرس ارسال.</returns>
    public override string ToString() =>
        $"Order with {this.Product.Count} items, Total: {this.TotalPrice:C}, Payment: {this.PaymentMethod}, Address: {this.ShippingAddress}";
}