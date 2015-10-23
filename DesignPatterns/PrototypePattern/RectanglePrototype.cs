using System;

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
            Console.WriteLine("Inside Rectangle::Draw() method." + Environment.NewLine);
        }
    }
}
