using FlyWeightSample.Model;

var factory = new SoldierFactory();
var type = factory.GetSoldierType("3DModel1", "GreenTexture");

var s1 = new Soldier(10, 20, type);
var s2 = new Soldier(30, 40, type);

s1.Draw();
s2.Draw();