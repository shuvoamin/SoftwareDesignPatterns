using System;
using System.Diagnostics;

namespace DesignPatterns.BuilderPattern
{
    public class BuilderPatternDemo
    {
        public MealBuilder MealBuilder
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var mealBuilder = new MealBuilder();

            //creating a vegetarian meal
            var vegetarianMeal = mealBuilder.PrepareVegetarianMeal();
            Trace.WriteLine("Vegetarian Meal" + Environment.NewLine);
            vegetarianMeal.ShowItems();
            Trace.WriteLine("Total Cost: " + vegetarianMeal.GetCost() + Environment.NewLine);

            //creating non vegetarian meal
            var nonVegetarianMeal = mealBuilder.PrepareNonVegetarianMeal();
            Trace.WriteLine("\n\n Non-Vegetarian Meal" + Environment.NewLine);
            nonVegetarianMeal.ShowItems();
            Trace.WriteLine("Total Cost: " + nonVegetarianMeal.GetCost() + Environment.NewLine);
        }
    }
}
