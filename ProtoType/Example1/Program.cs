using Example1;

Console.WriteLine("***Prototype Pattern Demo***\n");
// Base or Original Copy
BasicCar nano = new Nano("Green Nano");
nano.Color = "Green";
BasicCar ford = new Ford("Ford Yellow");
BasicCar basicCar;
// Nano
basicCar = nano.Clone();
// Working on cloned copy
basicCar.Color = "Black";
basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. { basicCar.onRoadPrice }");
// Ford
basicCar = ford.Clone();
// Working on cloned copy
basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. { basicCar.onRoadPrice }");

Console.ReadLine();