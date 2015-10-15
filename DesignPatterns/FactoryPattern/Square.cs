using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FactoryPattern
{
    public class Square : IShape
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
            Console.WriteLine("Inside Square::Draw() method." + Environment.NewLine);
        }
    }
}
