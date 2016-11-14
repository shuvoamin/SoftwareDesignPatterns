using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DesignPatterns.BuilderPattern
{
    public class Meal
    {
        private readonly List<IItem> _items = new List<IItem>();

        public IItem Item
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public float GetCost()
        {
            return _items.Sum(item => item.Price());
        }

        public void ShowItems()
        {
            foreach (var item in _items)
            {
                Trace.WriteLine("Item : " + item.Name());
                Trace.WriteLine(", Packing : " + item.Packing().Pack());
                Trace.WriteLine(", Price : " + item.Price());
            }
        }			
    }
}
