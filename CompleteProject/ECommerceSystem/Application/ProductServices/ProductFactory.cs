using Core.Models.Product;

namespace Application.ProductServices;

public abstract class ProductFactory
{
    public abstract ProductBase CreateProduct(string Name);
}