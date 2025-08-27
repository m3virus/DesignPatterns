namespace SingletonExample
{
    public class CheckLockLazySingleton
    {
        private static LazySingleton instance;
        private static readonly object locker = new object();
        public static LazySingleton Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new LazySingleton();

                    return instance;
                }
                
            }
        }
        public string Connection { get; set; } = "124";
    }
}
