using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.FlyweightPattern
{
    public class ShapeFactoryFlyweight
    {
        public CircleFlyweight CircleFlyweight
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static IShape GetCircle(string color)
        {
            var circle = new CircleFlyweight(color);
            Trace.WriteLine("Creating cricle of color : " + color);

            return circle;
        }
    }
}
