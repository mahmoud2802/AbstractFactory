namespace AbstractFactory
{
    public class VictorianChair:IChair
    {
        public string GetName()
        {
            return "This is a  Victorian Chair";
        }

        public bool HasLeg()
        {
            return true;
        }

        public int Price()
        {
            return 5000;
        }
    }
}