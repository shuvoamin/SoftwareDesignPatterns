using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.FactoryPattern
{
    public class Square : IShape
    {
        public IShape Shape
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DesignPatterns.Interfaces.IShape ShapeAbstract
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        //Override
        public void Draw()
        {
            Trace.WriteLine("Inside Square::Draw() method." + Environment.NewLine);
        }
    }
}
