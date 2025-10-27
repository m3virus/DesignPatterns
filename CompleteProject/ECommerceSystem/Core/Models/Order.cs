using Core.Models.Product;

namespace Core.Models;

public class Order
{
    public string CustormerName { get; set; }
    public List<ProductBase> Product { get; set; } = new ();
    public decimal TotalPrice { get; set; }
}