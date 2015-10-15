using DesignPatterns.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class AbstractFactoryPatternDemo
    {
        public FactoryProducer FactoryProducer
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public static void Output()
        {
            #region ShapeFactory
            //get shape factory
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("SHAPE");

            //get an object of shape circle
            IShape shape1 = shapeFactory.GetShape("CIRCLE");

            //call draw method of Shape Circle
            shape1.Draw();

            //get an object of shape Rectangle
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //call draw method of Shape Rectangle
            shape2.Draw();

            //get an object of shape square
            IShape shape3 = shapeFactory.GetShape("SQUARE");

            //call draw method of Shape square
            shape3.Draw(); 
            #endregion

            #region ColorFactory
            //get color factory
            AbstractFactory colorFactory = FactoryProducer.GetFactory("COLOR");

            //get an object of Color Red
            IColor color1 = colorFactory.GetColor("RED");

            //call fill method of Red
            color1.Fill();

            //get an object of Color Green
            IColor color2 = colorFactory.GetColor("GREEN");

            //call fill method of Green
            color2.Fill();

            //get an object of Color Blue
            IColor color3 = colorFactory.GetColor("BLUE");

            //call fill method of Color Blue
            color3.Fill(); 
            #endregion

        }
    }
}
