using System;

namespace DesignPatterns.CommandPattern
{
    public class Stock
    {
        private string _name = "ABC";
        private int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock [ name: " + _name + ", Quantity: " + _quantity + " ] bought" + Environment.NewLine);
        }

        public void Sell()
        {
            Console.WriteLine("Stock [ name: " + _name + ", Quantity: " + _quantity + " ] sold" + Environment.NewLine);
        }
    }
}
