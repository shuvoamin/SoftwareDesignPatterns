using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class BuilderPatternDemo
    {
        public MealBuilder MealBuilder
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            MealBuilder mealBuilder = new MealBuilder();

            //creating a vegetarian meal
            Meal vegetarianMeal = mealBuilder.PrepareVegetarianMeal();
            Console.WriteLine("Vegetarian Meal" + Environment.NewLine);
            vegetarianMeal.ShowItems();
            Console.WriteLine("Total Cost: " + vegetarianMeal.GetCost() + Environment.NewLine);

            //creating non vegetarian meal
            Meal nonVegetarianMeal = mealBuilder.PrepareNonVegetarianMeal();
            Console.WriteLine("\n\n Non-Vegetarian Meal" + Environment.NewLine);
            nonVegetarianMeal.ShowItems();
            Console.WriteLine("Total Cost: " + nonVegetarianMeal.GetCost() + Environment.NewLine);
        }
    }
}
