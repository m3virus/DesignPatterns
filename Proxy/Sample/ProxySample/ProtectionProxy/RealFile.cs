namespace ProxySample.ProtectionProxy
{
    internal class RealFile : IFile
    {
        private string fileName;
        public RealFile(string fileName) => this.fileName = fileName;
        public void Read() => Console.WriteLine($"Reading {fileName}");
    }
}
