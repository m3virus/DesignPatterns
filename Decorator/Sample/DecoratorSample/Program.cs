using DecoratorSample.Model;

INotifier notifier = new EmailNotifier();
notifier = new SMSNotifier(notifier);
notifier = new SlackNotifier(notifier);

notifier.Send("Hello World!");