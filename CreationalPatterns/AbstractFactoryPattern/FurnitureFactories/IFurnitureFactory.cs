using DesignPatterns.CreationalPatterns.AbstractFactoryPattern.Furniture;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern.FurnitureFactories;

public interface IFurnitureFactory
{
    public IChair CreateChair();

    public ITable CreateTable();

    public ISofa CreateSofa();
}