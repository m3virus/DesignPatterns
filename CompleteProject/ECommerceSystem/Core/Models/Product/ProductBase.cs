namespace Core.Models.Product;
//Factory Pattern
public abstract class ProductBase
{
    public string Name { get; set; }
    public abstract void Detail();
}