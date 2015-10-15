using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.AbstractFactoryPattern
{
    class Green : IColor
    {
        public IColor IColor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void Fill()
        {
            Console.WriteLine("Inside Green:: Fill() method." + Environment.NewLine);
        }
    }
}
