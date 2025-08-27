namespace SingletonExample
{
    //fill memory when you use it for first time
    //we should handle thread safe problem
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
