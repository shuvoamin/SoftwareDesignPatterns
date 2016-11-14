namespace DesignPatterns.BuilderPattern
{
    public class ChickenBurger : Burger
    {
        //Override
        public override string Name()
        {
            return "Chicken Burger";
        }

        //Override
        public override float Price()
        {
            return 50.0F;
        }
    }
}
