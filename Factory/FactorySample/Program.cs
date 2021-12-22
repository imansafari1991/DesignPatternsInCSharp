
using FactorySample;
using FactorySample.Entities;


CarFactory factory=new CarFactory();
var car = factory.GetCar("B");

car.Start();
foo();
bar();
Console.ReadKey();




static void foo()
{
    CarFactory factory = new CarFactory();
    var car = factory.GetCar("F");

    car.Start();
    Console.ReadKey();
}

static void bar() {
    CarFactory factory = new CarFactory();
    var car = factory.GetCar("H");

    car.Start();
    Console.ReadKey();
}