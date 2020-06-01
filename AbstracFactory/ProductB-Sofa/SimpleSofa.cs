namespace AbstractFactory
{
    public class SimpleSofa:ISofa
    {
        public int Price()
        {
            return 500;
        }

        public string GetName()
        {
            return "This is a simple Sofa";
        }

        public void IsComfortable()
        {
            throw new System.NotImplementedException();
        }
    }
}