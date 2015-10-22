using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FactoryPattern
{
    public class Circle : IShape
    {
        public IShape Shape
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void Draw()
        {
            Console.WriteLine("Inside Circle::Draw() method." + Environment.NewLine);
        }
    }
}
