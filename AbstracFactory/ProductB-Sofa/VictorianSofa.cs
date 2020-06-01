namespace AbstractFactory
{
    public class VictorianSofa:ISofa
    {
        public int Price()
        {
            return 500;
        }

        public string GetName()
        {
            return "This is a Victorian Sofa";
        }

        public void IsComfortable()
        {
            throw new System.NotImplementedException();
        }
    }
}