using BridgePattern.Abstraction;

namespace BridgePattern.Shapes
{
    internal class Square:IRender
    {
        public void Shape(int radius)
        {
            Console.WriteLine(2 * radius);
            
        }
    }
}
