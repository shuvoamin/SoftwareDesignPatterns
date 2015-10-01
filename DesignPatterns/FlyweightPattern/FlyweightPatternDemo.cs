using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyweightPattern
{
    public class FlyweightPatternDemo
    {
        private static readonly Random randomNum = new Random();

        private static readonly string[] _colors = { "Red", "Green", "Blue", "White", "Black" };

        public ShapeFactoryFlyweight ShapeFactoryFlyweight
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
            return _colors[randomNum.Next(0, 4)];
        }

        private static int GetRandomX()
        {
            return randomNum.Next(0, 4);
        }

        private static int GetRandomY()
        {
            return randomNum.Next(0, 4);
        }
    }
}
