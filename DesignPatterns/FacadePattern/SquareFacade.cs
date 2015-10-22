using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.FacadePattern
{
    public class SquareFacade : IShape
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
            Console.WriteLine("Square::draw()" + Environment.NewLine);
        }
    }
}
