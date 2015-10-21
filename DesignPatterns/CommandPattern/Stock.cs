using System;

namespace DesignPatterns.CommandPattern
{
    public class Stock
    {
        private const string Name = "ABC";
        private const int Quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock [ name: " + Name + ", Quantity: " + Quantity + " ] bought" + Environment.NewLine);
        }

        public void Sell()
        {
            Console.WriteLine("Stock [ name: " + Name + ", Quantity: " + Quantity + " ] sold" + Environment.NewLine);
        }
    }
}
