using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesignPatterns.PrototypePattern
{
    public class ShapePrototypeCache
    {
        private static Dictionary<int, ShapePrototype> shapeMap = new Dictionary<int, ShapePrototype>();

        public static ShapePrototype GetShape(int shapeId)
        {
            if (shapeMap.ContainsKey(shapeId))
            {
                ShapePrototype cachedShape = shapeMap[shapeId];

                return (ShapePrototype)cachedShape.Clone();
            }

            return null;
        }

        // for each shape run database query and create shape
        // shapeMap.put(shapeKey, shape);
        // for example, we are adding three shapes
        public static void LoadCache()
        {
            CirclePrototype circle = new CirclePrototype();
            circle.SetId(1);
            shapeMap.Add(circle.GetId(), circle);

            SquarePrototype square = new SquarePrototype();
            square.SetId(2);
            shapeMap.Add(square.GetId(), square);

            RectanglePrototype rectangle = new RectanglePrototype();
            rectangle.SetId(3);
            shapeMap.Add(rectangle.GetId(), rectangle);
        }
    }
}
