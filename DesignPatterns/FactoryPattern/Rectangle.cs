using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.FactoryPattern
{
    public class Rectangle : IShape
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
            Console.WriteLine("Inside Rectangle::Draw() method." + Environment.NewLine);
        }
    }
}
