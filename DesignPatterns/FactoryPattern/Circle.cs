using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

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
            Trace.WriteLine("Inside Circle::Draw() method." + Environment.NewLine);
        }
    }
}
