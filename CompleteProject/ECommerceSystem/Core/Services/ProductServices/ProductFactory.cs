using Core.Models.Product;

namespace Core.Services.ProductServices;

public abstract class ProductFactory
{
    public abstract ProductBase CreateProduct(string Name);
}