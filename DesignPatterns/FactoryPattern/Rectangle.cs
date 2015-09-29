using DesignPatterns.FactoryPattern;
using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.FactoryPattern
{
    public class Rectangle : IShape
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
            Console.WriteLine("Inside Rectangle::Draw() method." + Environment.NewLine);
        }
    }
}
