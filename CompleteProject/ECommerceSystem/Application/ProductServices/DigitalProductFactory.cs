using Core.Models.Product;

namespace Application.ProductServices;

internal class DigitalProductFactory:ProductFactory
{
    public override ProductBase CreateProduct(string Name) => new DigitalProduct{ Name = Name };
}