namespace Example1;

class ConcreteHome : AbstractHome
{
    public ConcreteHome()
    {
        AdditionalPrice = 0;
    }
    public override void MakeHome()
    {
        Console.WriteLine($"Original House is constructed.Price for this $10000");
    }
}