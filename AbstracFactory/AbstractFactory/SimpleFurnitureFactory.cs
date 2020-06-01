namespace AbstractFactory.AbstractFactory
{
    public class SimpleFurnitureFactory:IFurnitureFactory
    {
        public string GetName()
        {
            return "These Are Simple Furniture";
        }
        public IChair CreateChair()
        {
            return new SimpleChair();
        }

        public ITable CreateTable()
        {
            return new SimpleTable();
        }

        public ISofa CreateSofa()
        {
            return new SimpleSofa();
        }
    }
}