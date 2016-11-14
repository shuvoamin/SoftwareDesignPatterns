namespace DesignPatterns.BuilderPattern
{
    public class MealBuilder
    {
        public Meal Meal
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public Meal PrepareVegetarianMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegetarianBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        public Meal PrepareNonVegetarianMeal()
        {
            var meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
