using DesignPatterns.CreationalPatterns.AbstractFactoryPattern.Furniture;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern.VictorianFurniture;

public class VictorianTable : ITable
{
    public void ToPlaceThingsOn()
    {
        Console.WriteLine("sets things down carefully");
    }
}