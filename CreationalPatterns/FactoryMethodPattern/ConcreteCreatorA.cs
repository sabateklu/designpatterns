namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern;

public class ConcreteCreatorA : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductA();
    }
}