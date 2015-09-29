using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern
{
    public class RectanglePrototype : ShapePrototype
    {
        public RectanglePrototype()
        {
            type = "Rectangle";
        }


        //Override
        public override void draw()
        {
            Console.WriteLine("Inside Rectangle::Draw() method." + Environment.NewLine);
        }
    }
}
