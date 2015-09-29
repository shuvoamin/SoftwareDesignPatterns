using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern
{
    public class SquarePrototype : ShapePrototype
    {
        public SquarePrototype()
        {
            type = "Square";
        }

        //Override
        public override void draw()
        {
            Console.WriteLine("Inside Square::Draw() method." + Environment.NewLine);
        }
    }
}
