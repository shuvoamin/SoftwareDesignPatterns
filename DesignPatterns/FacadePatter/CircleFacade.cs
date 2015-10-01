using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
