using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FacadePatter
{
    public class SquareFacade : IShape
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
            Console.WriteLine("Square::draw()" + Environment.NewLine);
        }
    }
}
