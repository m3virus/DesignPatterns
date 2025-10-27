namespace Core.Patterns;

//Prototype pattern
public abstract class ProductPrototype
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public abstract ProductPrototype Clone();
}