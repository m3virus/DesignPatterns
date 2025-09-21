using BridgePattern.Abstraction;

namespace BridgePattern
{
    internal class Circumference:Radius

    {
        public Circumference(IRender render) : base(render)
        {
        }

        public override void GetRadius(int radius)
        {
            render.Shape(radius);
        }
        
    }
}
