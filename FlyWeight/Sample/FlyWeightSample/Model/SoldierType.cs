namespace FlyWeightSample.Model
{
    public class SoldierType
    {
        public string Model { get; }
        public string Texture { get; }

        public SoldierType(string model, string texture)
        {
            Model = model;
            Texture = texture;
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Render soldier at ({x},{y}) with {Model} & {Texture}");
        }
    }
}
