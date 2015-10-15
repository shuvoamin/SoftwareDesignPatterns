using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FacadePatter
{
    public class CircleFacade : IShape
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
        //Override
        public void Draw()
        {
            Console.WriteLine("Circle::draw()" + Environment.NewLine);
        }
    }
}
