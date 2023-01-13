namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern;

public abstract class Creator
{
    public abstract IProduct CreateProduct();

    public int TwoPlusTwo()
    {
        return 4;
    }
}