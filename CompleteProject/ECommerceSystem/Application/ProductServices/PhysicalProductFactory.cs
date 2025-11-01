using Core.Models.Product;

namespace Application.ProductServices;

public class PhysicalProductFactory: ProductFactory
{
    public override ProductBase CreateProduct(string name) => new PhysicalProduct
    {
        Name = name
    };
    
}