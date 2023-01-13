using DesignPatterns.CreationalPatterns.AbstractFactoryPattern.Furniture;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern.VictorianFurniture;

public class VictorianChair : IChair
{
    public void ToSitOn()
    {
        Console.WriteLine("Sits carefully");
    }
}