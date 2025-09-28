namespace ProxySample.ProtectionProxy
{
    internal class FileProxy : IFile
    {
        private RealFile realFile;
        private string role;

        public FileProxy(string fileName, string role)
        {
            realFile = new RealFile(fileName);
            this.role = role;
        }

        public void Read()
        {
            if (role == "Admin")
                realFile.Read();
            else
                Console.WriteLine("Access Denied!");
        }
    }
}
