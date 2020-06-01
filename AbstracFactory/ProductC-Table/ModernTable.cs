namespace AbstractFactory
{
    public class ModernTable:ITable
    {
        public string GetName()
        {
            return "This is a Modern Table";
        }

        public int Price()
        {
            return 80000;
        }

        public void HasLeg()
        {
            throw new System.NotImplementedException();
        }
    }
}