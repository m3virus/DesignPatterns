namespace SingletonExample
{
    //eager initialization 
    //advantages: 
    //Faster, safer, 
    //it fill the memory when you call it for first time

    //better for logger because we use it in all classes and methods
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        public static Singleton Instance => instance;

        public string Connection { get; set; } = "124";
    }
}
