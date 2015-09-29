using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern
{
    public class PrototypePatternDemo
    {
        public static void Output()
        {
            ShapePrototypeCache.LoadCache();

            ShapePrototype clonedShape = (ShapePrototype)ShapePrototypeCache.GetShape(1);
            Console.WriteLine("Shape : " + clonedShape.GetType() + Environment.NewLine);

            ShapePrototype clonedShape2 = (ShapePrototype)ShapePrototypeCache.GetShape(2);
            Console.WriteLine("Shape : " + clonedShape2.GetType() + Environment.NewLine);

            ShapePrototype clonedShape3 = (ShapePrototype)ShapePrototypeCache.GetShape(3);
            Console.WriteLine("Shape : " + clonedShape3.GetType() + Environment.NewLine);
        }
    }
}
