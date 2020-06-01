namespace AbstractFactory
{
    public class SimpleTable:ITable
    {
        public string GetName()
        {
            return "This is a simple table";
        }

        public int Price()
        {
            return 70000;
        }

        public void HasLeg()
        {
            throw new System.NotImplementedException();
        }
    }
}