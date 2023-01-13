using DesignPatterns.CreationalPatterns.AbstractFactoryPattern.Furniture;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern.VictorianFurniture;

public class VictorianSofa : ISofa
{
    public void ToLayOn()
    {
        Console.WriteLine("lays down carefully");
    }
}