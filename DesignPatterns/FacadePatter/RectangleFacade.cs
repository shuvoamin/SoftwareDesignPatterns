using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FacadePatter
{
    public class RectangleFacade : IShape
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
            Console.WriteLine("Rectangle::draw()" + Environment.NewLine);
        }
    }
}
