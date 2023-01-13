namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern;

public class ConcreteProductA : IProduct
{
    private static string Name => "ConcreteProductA";
        
    public string GetName()
    {
        return Name;
    }
}