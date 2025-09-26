namespace DecoratorSample.Model
{
    public class NotifierDecorator:INotifier
    {
        protected readonly INotifier instance;

        protected NotifierDecorator(INotifier instance)
        {
            this.instance = instance;
        }
        public virtual void Send(string message)
        {
            instance.Send(message);
        }
    }
}
