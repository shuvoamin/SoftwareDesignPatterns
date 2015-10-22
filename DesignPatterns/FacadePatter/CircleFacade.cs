using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FacadePatter
{
    public class CircleFacade : IShape
    {
        public IShape Shape
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void Draw()
        {
            Console.WriteLine("Circle::draw()" + Environment.NewLine);
        }
    }
}
