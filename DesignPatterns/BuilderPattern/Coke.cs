namespace DesignPatterns.BuilderPattern
{
    public class Coke : ColdDrink
    {
        //Override
        public override string Name()
        {
            return "Coke";
        }

        //Overide
        public override float Price()
        {
            return 35.0F;
        }
    }
}
