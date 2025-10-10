using StrategyPattern.DifferentStrategy;
using StrategyPattern.Model;

var a = new ShoppingCart();

a.CheckOut(111);

a.SetStrategy(new BitcoinPayment());
a.CheckOut(111);

a.SetStrategy(new CardPayment());
a.CheckOut(111);

a.SetStrategy(new PaypalPayment());
a.CheckOut(1222);