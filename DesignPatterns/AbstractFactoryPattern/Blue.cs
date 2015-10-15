using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.AbstractFactoryPattern
{
    class Blue : IColor
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
            Console.WriteLine("Inside Blue:: Fill() method." + Environment.NewLine);
        }
    }
}
