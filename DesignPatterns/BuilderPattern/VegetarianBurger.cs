namespace DesignPatterns.BuilderPattern
{
    public class VegetarianBurger : Burger
    {
        //Override
        public override string Name()
        {
            return "Chicken Burger";
        }

        //Override
        public override float Price()
        {
            return 25.0F;
        }
    }
}
