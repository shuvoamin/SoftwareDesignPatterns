namespace DesignPatterns.BuilderPattern
{
    public class Pepsi : ColdDrink
    {
        //Override
        public override string name()
        {
            return "Pepsi";
        }

        //Overide
        public override float price()
        {
            return 30.0F;
        }
    }
}
