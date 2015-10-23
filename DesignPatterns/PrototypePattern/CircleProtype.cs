using System;
using System.Diagnostics;

namespace DesignPatterns.PrototypePattern
{
    public class CirclePrototype : ShapePrototype
    {
        public CirclePrototype()
        {
            Type = "Circle";
        }

        //Override
        public override void Draw()
        {
            Trace.WriteLine("Inside Circle::Draw() method." + Environment.NewLine);
        }
    }
}
