namespace AbstractFactory
{
    public class ModernChair:IChair
    {
        public string GetName()
        {
            return "This is a Modern Chair";
        }

        public bool HasLeg()
        {
            return false;
        }

        public int Price()
        {
            return 10000;
        }
    }
}