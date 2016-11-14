using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.FactoryPattern
{
    public class Circle : IShape
    {
        public DesignPatterns.Interfaces.IShape Shape
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        //Override
        public void Draw()
        {
            Trace.WriteLine("Inside Circle::Draw() method." + Environment.NewLine);
        }
    }
}
