namespace AbstractFactory.AbstractFactory
{
    public interface IFurnitureFactory
    {
        string GetName();
        IChair CreateChair();
        ITable CreateTable();
        ISofa CreateSofa();

    }
}