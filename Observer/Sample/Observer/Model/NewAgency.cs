namespace Observer.Model
{
    internal class NewAgency
    {
        private List<ISubscriber> _subscribers = new ();

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void PublishNews(string news)
        {
            Console.WriteLine($"New Agency : {news}");
            foreach (var sub in _subscribers)
            {
                sub.Update(news);
            }
        }
    }
}
