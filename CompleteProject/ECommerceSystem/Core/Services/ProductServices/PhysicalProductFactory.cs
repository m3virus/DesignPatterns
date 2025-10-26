using System.Security.Cryptography.X509Certificates;
using Core.Models.Product;

namespace Core.Services.ProductServices;

public class PhysicalProductFactory: ProductFactory
{
    public override ProductBase CreateProduct(string Name) => new PhysicalProduct
    {
        Name = Name
    };
    
}