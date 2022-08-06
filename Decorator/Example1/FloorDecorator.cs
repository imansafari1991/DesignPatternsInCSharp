namespace Example1;

// Floor Decorator is used to add a floor
class FloorDecorator : AbstractDecorator
{
    public FloorDecorator(AbstractHome home) : base(home)
    {
        //this.home = home;
        this.AdditionalPrice = 2500;
    }
    public override void MakeHome()
    {
        base.MakeHome();
        // Adding a floor on top of original house.
        AddFloor();
    }
    private void AddFloor()
    {
        Console.WriteLine($"-Additional Floor added.Pay additional ${ AdditionalPrice} for it.");
    }
}