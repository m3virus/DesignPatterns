namespace SingletonExample
{
    //fill memory when you use it for first time
    //we should handle thread safe problem

    //better for something like connection string that we won't use in all classes
    public class LazySingleton
    {
        private static LazySingleton instance;

        public static LazySingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new LazySingleton();
                
                return instance;
            }
        }
        public string Connection { get; set; } = "124";

    }
}
