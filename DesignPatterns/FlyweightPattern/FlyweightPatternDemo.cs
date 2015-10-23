using System;

namespace DesignPatterns.FlyweightPattern
{
    public class FlyweightPatternDemo
    {
        private static readonly Random RandomNum = new Random();

        private static readonly string[] Colors = { "Red", "Green", "Blue", "White", "Black" };

        public ShapeFactoryFlyweight ShapeFactoryFlyweight
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static void Output()
        {
            for (int i = 0; i < 20; ++i)
            {
                CircleFlyweight circle = (CircleFlyweight)ShapeFactoryFlyweight.GetCircle(GetRandomColor());
                circle.X = GetRandomX();
                circle.Y = GetRandomY();
                circle.Radius = 100;
                circle.Draw();
            }
        }
        private static string GetRandomColor()
        {
            return Colors[RandomNum.Next(0, 4)];
        }

        private static int GetRandomX()
        {
            return RandomNum.Next(0, 4);
        }

        private static int GetRandomY()
        {
            return RandomNum.Next(0, 4);
        }
    }
}
