using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FactoryPattern
{
    public class Circle : IShape
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
            Console.WriteLine("Inside Circle::Draw() method." + Environment.NewLine);
        }
    }
}
