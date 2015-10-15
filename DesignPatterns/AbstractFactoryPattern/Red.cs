using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class Red : IColor
    {
        public IColor IColor
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
        public void Fill()
        {
            Console.WriteLine("Inside Red:: Fill() method." + Environment.NewLine);
        }
    }
}
