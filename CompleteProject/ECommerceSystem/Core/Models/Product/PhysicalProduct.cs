using Core.Patterns;

namespace Core.Models.Product;

/// <summary>
/// The model for physical products
/// </summary>
public class PhysicalProduct : ProductBase
{
    /// <inheritdoc />
    public override void Detail()
    {
        Console.WriteLine($"You built {this.Name} as physical product");
    }

    /// <inheritdoc />
    public override ProductPrototype Clone()
    {
        return (PhysicalProduct)this.MemberwiseClone();
    }
}