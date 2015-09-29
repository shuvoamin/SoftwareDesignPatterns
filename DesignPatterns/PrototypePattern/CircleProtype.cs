using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern
{
    public class CirclePrototype : ShapePrototype
    {
        public CirclePrototype()
        {
            type = "Circle";
        }

        //Override
        public override void draw()
        {
            Console.WriteLine("Inside Circle::Draw() method." + Environment.NewLine);
        }
    }
}
