namespace Core.Models.Product;

internal class DigitalProduct : ProductBase
{
    public override void Detail()
    {
        Console.WriteLine($"You built {base.Name} as physical product");
    }

    public override ProductPrototype Clone()
    {
        return (DigitalProduct)this.MemberwiseClone();
    }
}