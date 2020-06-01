namespace AbstractFactory.AbstractFactory
{
    public class VictorianFurnitureFactory:IFurnitureFactory
    {
        public string GetName()
        {
            return "These Are Victorian Furniture";
        }
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
}