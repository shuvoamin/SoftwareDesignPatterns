using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

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
            Trace.WriteLine("Shape: Circle" + Environment.NewLine);
        }
    }
}
