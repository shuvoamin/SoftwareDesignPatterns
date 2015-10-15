using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.DecoratorPattern
{
    class CircleDecorator : IShape
    {
        public IShape IShape
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
        //Override
        public void Draw()
        {
            Console.WriteLine("Shape: Circle" + Environment.NewLine);
        }
    }
}
