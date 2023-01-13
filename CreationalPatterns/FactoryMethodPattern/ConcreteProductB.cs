namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern;

public class ConcreteProductB : IProduct
{
    private static string Name => "ConcreteProductB";
        
    public string GetName()
    {
        return Name;
    }
}