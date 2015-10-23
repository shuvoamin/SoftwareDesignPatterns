using System;

namespace DesignPatterns.PrototypePattern
{
    public class PrototypePatternDemo
    {
        public ShapePrototypeCache ShapePrototypeCache
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            ShapePrototypeCache.LoadCache();

            var clonedShape = (ShapePrototype)ShapePrototypeCache.GetShape(1);
            Console.WriteLine("Shape : " + clonedShape.GetType() + Environment.NewLine);

            var clonedShape2 = (ShapePrototype)ShapePrototypeCache.GetShape(2);
            Console.WriteLine("Shape : " + clonedShape2.GetType() + Environment.NewLine);

            var clonedShape3 = (ShapePrototype)ShapePrototypeCache.GetShape(3);
            Console.WriteLine("Shape : " + clonedShape3.GetType() + Environment.NewLine);
        }
    }
}
