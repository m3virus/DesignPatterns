namespace CompositeSample.Models
{
    internal class FileItem:FileSystemItem
    {
        public FileItem(string Name) : base(Name)
        {
        }

        public override void Display(int Depth)
        {
            Console.WriteLine(new string('_', Depth) + Name);
        }
    }
}
