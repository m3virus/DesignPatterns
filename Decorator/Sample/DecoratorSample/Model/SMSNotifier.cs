namespace DecoratorSample.Model
{
    public class SMSNotifier : NotifierDecorator
    {
        public SMSNotifier(INotifier instance) : base(instance)
        {
        }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"SMS send:{message}");
        }
    }
}
