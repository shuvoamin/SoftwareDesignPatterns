using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns.FlyweightPattern
{
    public class ShapeFactoryFlyweight
    {
        private static readonly Dictionary<string, IShape> CircleMap = new Dictionary<string, IShape>();

        public CircleFlyweight CircleFlyweight
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static IShape GetCircle(string color)
        {
            CircleFlyweight circle = (CircleFlyweight)CircleMap[color];

            if (circle == null)
            {
                circle = new CircleFlyweight(color);
                CircleMap.Add(color, circle);
                Console.WriteLine("Creating cricle of color : " + color);
            }

            return circle;
        }
    }
}
