using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set
            {
            }
        }
    
        public Meal PrepareVegetarianMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new VegetarianBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        public Meal PrepareNonVegetarianMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
