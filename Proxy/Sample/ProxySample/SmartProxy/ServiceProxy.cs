namespace ProxySample.SmartProxy
{
    internal class ServiceProxy : IService
    {
        private Service Proxy;
        public void Execute()
        {
            Console.WriteLine("[DBG] service started");
            Proxy.Execute();
            Console.WriteLine("[DBG] service finished");
        }
    }
}
