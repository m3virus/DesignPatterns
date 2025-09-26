namespace DecoratorSample.Model
{
    public class SlackNotifier:NotifierDecorator
    {
        public SlackNotifier(INotifier instance) : base(instance)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Slack send: {message}");
        }
    }
}
