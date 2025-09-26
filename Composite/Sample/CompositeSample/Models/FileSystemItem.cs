namespace CompositeSample.Models
{
    public abstract class FileSystemItem
    {
        protected string Name { get; set; }
        protected FileSystemItem (string Name) => this.Name = Name;
        public abstract void Display(int Depth = 0);
    }
}
