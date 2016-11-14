using System;
using System.Diagnostics;

namespace DesignPatterns.PrototypePattern
{
    public class SquarePrototype : ShapePrototype
    {
        public SquarePrototype()
        {
            Type = "Square";
        }

        //Override
        public override void Draw()
        {
            Trace.WriteLine("Inside Square::Draw() method." + Environment.NewLine);
        }
    }
}
