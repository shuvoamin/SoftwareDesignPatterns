using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns.BuilderPattern
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();

        public DesignPatterns.Interfaces.IItem IItem
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0F;

            foreach (IItem item in items)
            {
                cost += item.price();
            }
      		
            return cost;
        }

        public void ShowItems()
        {
            foreach (IItem item in items)
            {
                Console.WriteLine("Item : " + item.name());
                Console.WriteLine(", Packing : " + item.packing().pack());
                Console.WriteLine(", Price : " + item.price());
            }
        }			
    }
}
