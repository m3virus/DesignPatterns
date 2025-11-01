using Core.Patterns;

namespace Core.Models.Product;

/// <inheritdoc />
public class DigitalProduct : ProductBase
{
#pragma warning disable SA1101
    /// <inheritdoc />
    public override void Detail() => Console.WriteLine($"You built {Name} as physical product");
#pragma warning restore SA1101

    /// <inheritdoc />
    public override ProductPrototype Clone()
    {
        return (DigitalProduct)this.MemberwiseClone();
    }
}