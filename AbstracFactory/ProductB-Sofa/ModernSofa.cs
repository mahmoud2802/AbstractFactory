namespace AbstractFactory
{
    public class ModernSofa:ISofa
    {
        public int Price()
        {
            return 20000;
        }

        public string GetName()
        {
            return "This is a Modern Sofa";
            
        }

        

        public void IsComfortable()
        {
            throw new System.NotImplementedException();
        }
    }
}