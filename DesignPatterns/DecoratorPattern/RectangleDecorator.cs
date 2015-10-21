using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.DecoratorPattern
{
    class RectangleDecorator : IShape
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
            Console.WriteLine("Shape: Rectanlge" + Environment.NewLine);
        }
    }
}
