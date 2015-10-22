using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.FactoryPattern
{
    public class Rectangle : IShape
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

        public IShape IShape1
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
            Console.WriteLine("Inside Rectangle::Draw() method." + Environment.NewLine);
        }
    }
}
