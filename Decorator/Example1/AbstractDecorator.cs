namespace Example1;

abstract class AbstractDecorator : AbstractHome
{
    protected AbstractHome home;
    public AbstractDecorator(AbstractHome home)
    {
        this.home = home;
        this.AdditionalPrice = 0;
    }
    public override void MakeHome()
    {
        home.MakeHome();//Delegating task
    }
}