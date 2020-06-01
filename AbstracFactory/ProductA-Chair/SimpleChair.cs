namespace AbstractFactory
{
    public class SimpleChair:IChair
    {
        public string GetName()
        {
            return "This is a Simple Chair";
        }

        public bool HasLeg()
        {
            return true;
        }

        public int Price()
        {
            return 2000;
        }
    }
}