using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FacadePatter
{
    public class RectangleFacade : IShape
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
            Console.WriteLine("Rectangle::draw()" + Environment.NewLine);
        }
    }
}
