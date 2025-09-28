namespace ProxySample.VirualProxy
{
    public class ImageProxy :IImage
    {
        private RealImage realImage;
        private string fileName;


        public ImageProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            realImage ??= new RealImage(fileName);
            realImage.Display();
        }
    }
}
