namespace Example2;

abstract class Creator
{

    public abstract Product FactoryMethod();
}

class ConcreteCreator1 : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}

class ConcreteCreator2 : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProduct2();
    }
}