namespace Prototype.Class
{
    internal abstract class Entity
    {
        public int Power { get; set; }
        public string Name { get; set; }

        public abstract Entity ClonEntity();
    }
}
