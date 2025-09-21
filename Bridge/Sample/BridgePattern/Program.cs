using BridgePattern;
using BridgePattern.Shapes;

var x = new Circumference(new Circle());
x.GetRadius(3);

var y = new Circumference(new Square());
y.GetRadius(4);