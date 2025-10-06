using Observer.Model;

var agency = new NewAgency();

var ali = new Subscriber("Ali");
var sara = new Subscriber("Sara");
var reza = new Subscriber("Reza");

agency.Subscribe(ali);
agency.Subscribe(sara);

agency.PublishNews("🚀 New rocket launched!");
agency.PublishNews("💰 Inflation rate decreased!");

agency.Unsubscribe(ali);

agency.PublishNews("🌦 Rain expected tomorrow");