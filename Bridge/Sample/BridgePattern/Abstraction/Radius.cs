namespace BridgePattern.Abstraction
{
    public abstract class Radius
    {
        protected IRender render;

        public Radius(IRender render)
        {
            this.render = render;
        }

        public abstract void GetRadius(int radius);
    }
}
