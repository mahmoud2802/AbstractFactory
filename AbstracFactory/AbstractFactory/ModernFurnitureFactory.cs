namespace AbstractFactory.AbstractFactory
{
    public class ModernFurnitureFactory:IFurnitureFactory
    {
        public string GetName()
        {
            return "These Are Modern Furniture";
        }

        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
            
        }
    }
}