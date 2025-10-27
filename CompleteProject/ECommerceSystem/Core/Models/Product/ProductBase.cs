using Core.Patterns;

namespace Core.Models.Product;

//Factory Pattern
public abstract class ProductBase:ProductPrototype
{
    public abstract void Detail();
}