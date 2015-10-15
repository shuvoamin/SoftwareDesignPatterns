using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FacadePatter
{
    public class RectangleFacade : IShape
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
            Console.WriteLine("Rectangle::draw()" + Environment.NewLine);
        }
    }
}
