namespace CompositeSample.Models
{
    public class FolderItem:FileSystemItem
    {
        private readonly List<FileSystemItem> Children = new();

        public FolderItem(string Name) : base(Name)
        {
        }

        public void Add(FileSystemItem item)
        {
            Children.Add(item);
        }
        public override void Display(int Depth = 0)
        {
            Console.WriteLine(new string('_', Depth) + Name);
            foreach (var counter in Children)
            {
                counter.Display(Depth + 2);
            }
        }
    }
}
