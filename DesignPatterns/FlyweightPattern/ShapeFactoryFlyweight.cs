using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns.FlyweightPattern
{
    public class ShapeFactoryFlyweight
    {
        private static readonly Dictionary<string, IShape> circleMap = new Dictionary<string, IShape>();

        public CircleFlyweight CircleFlyweight
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public static IShape GetCircle(string color)
        {
            CircleFlyweight circle = (CircleFlyweight)circleMap[color];

            if (circle == null)
            {
                circle = new CircleFlyweight(color);
                circleMap.Add(color, circle);
                Console.WriteLine("Creating cricle of color : " + color);
            }

            return circle;
        }
    }
}
