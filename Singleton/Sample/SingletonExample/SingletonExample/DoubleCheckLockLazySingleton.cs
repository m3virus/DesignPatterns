namespace SingletonExample
{
    public class DoubleCheckLockLazySingleton
    {
        private static LazySingleton instance;
        private static readonly object locker = new object();
        public static LazySingleton Instance
        {
            get
            {

                if (instance == null)
                {
                    lock (locker)
                    {
                        instance = new LazySingleton();

                    }
                }
                return instance;
            }
        }
        public string Connection { get; set; } = "124";
    }
}
