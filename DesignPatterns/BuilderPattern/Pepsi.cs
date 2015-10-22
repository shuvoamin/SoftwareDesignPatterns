namespace DesignPatterns.BuilderPattern
{
    public class Pepsi : ColdDrink
    {
        //Override
        public override string Name()
        {
            return "Pepsi";
        }

        //Overide
        public override float Price()
        {
            return 30.0F;
        }
    }
}
