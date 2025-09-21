using BridgePattern.Abstraction;

namespace BridgePattern.Shapes
{
    internal class Circle:IRender
    {
        public void Shape(int radius)
        {
            Console.WriteLine(Math.PI * radius * 2);
        }
    }
}
