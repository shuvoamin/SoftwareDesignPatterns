using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FacadePatter
{
    public class CircleFacade : IShape
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
        //Override
        public void Draw()
        {
            Console.WriteLine("Circle::draw()" + Environment.NewLine);
        }
    }
}
