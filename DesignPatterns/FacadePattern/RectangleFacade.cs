using System;
using System.Diagnostics;
using DesignPatterns.Interfaces;

namespace DesignPatterns.FacadePattern
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
            Trace.WriteLine("Rectangle::draw()" + Environment.NewLine);
        }
    }
}
