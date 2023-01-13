using DesignPatterns.CreationalPatterns.AbstractFactoryPattern.Furniture;
using DesignPatterns.CreationalPatterns.AbstractFactoryPattern.VictorianFurniture;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern.FurnitureFactories;

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ITable CreateTable()
    {
        return new VictorianTable();
    }

    public ISofa CreateSofa()
    {
        return new VictorianSofa();
    }
}