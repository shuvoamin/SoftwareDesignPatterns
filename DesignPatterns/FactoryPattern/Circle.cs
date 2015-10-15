using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FactoryPattern
{
    public class Circle : IShape
    {
        public DesignPatterns.Interfaces.IShape IShape
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DesignPatterns.Interfaces.IShape IShape1
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
            Console.WriteLine("Inside Circle::Draw() method." + Environment.NewLine);
        }
    }
}
