namespace AbstractFactory
{
    public class VictorianTable:ITable
    {
        public string GetName()
        {
            return "This is a victorian Table";
        }

        public int Price()
        {
            return 9000;
        }

        public void HasLeg()
        {
            throw new System.NotImplementedException();
        }
    }
}