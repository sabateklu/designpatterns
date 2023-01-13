namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern;

public class ConcreteCreatorB : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductB();
    }
}