﻿using System;

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
