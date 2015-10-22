using DesignPatterns.Interfaces;
using System;

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

        //Override
        public void Draw()
        {
            Console.WriteLine("Inside Square::Draw() method." + Environment.NewLine);
        }
    }
}
