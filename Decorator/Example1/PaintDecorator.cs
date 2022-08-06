namespace Example1;

class PaintDecorator : AbstractDecorator
{
    public PaintDecorator(AbstractHome home) : base(home)
    {
        //this.home = home;
        this.AdditionalPrice = 5000;
    }
    public override void MakeHome()
    {
        base.MakeHome();
        // Painting home.
        PaintHome();
    }
    private void PaintHome()
    {
        Console.WriteLine($"--Painting done.Pay additional ${ AdditionalPrice} for it.");
    }
}