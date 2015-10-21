using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.DecoratorPattern
{
    class CircleDecorator : IShape
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
            Console.WriteLine("Shape: Circle" + Environment.NewLine);
        }
    }
}
