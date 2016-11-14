using System;
using System.Diagnostics;

namespace DesignPatterns.PrototypePattern
{
    public class RectanglePrototype : ShapePrototype
    {
        public RectanglePrototype()
        {
            Type = "Rectangle";
        }

        //Override
        public override void Draw()
        {
            Trace.WriteLine("Inside Rectangle::Draw() method." + Environment.NewLine);
        }
    }
}
