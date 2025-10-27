using Core.Models.Product;

namespace Application.ProductServices;

public class PhysicalProductFactory: ProductFactory
{
    public override ProductBase CreateProduct(string Name) => new PhysicalProduct
    {
        Name = Name
    };
    
}