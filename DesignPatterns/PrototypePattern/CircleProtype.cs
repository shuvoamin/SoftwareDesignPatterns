using System;

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
            Console.WriteLine("Inside Circle::Draw() method." + Environment.NewLine);
        }
    }
}
