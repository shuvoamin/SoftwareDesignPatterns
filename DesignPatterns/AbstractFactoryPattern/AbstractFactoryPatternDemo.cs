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
            var shapeFactory = FactoryProducer.GetFactory("SHAPE");

            //get an object of shape circle
            var shape1 = shapeFactory.GetShape("CIRCLE");

            //call draw method of Shape Circle
            shape1.Draw();

            //get an object of shape Rectangle
            var shape2 = shapeFactory.GetShape("RECTANGLE");

            //call draw method of Shape Rectangle
            shape2.Draw();

            //get an object of shape square
            var shape3 = shapeFactory.GetShape("SQUARE");

            //call draw method of Shape square
            shape3.Draw(); 
            #endregion

            #region ColorFactory
            //get color factory
            var colorFactory = FactoryProducer.GetFactory("COLOR");

            //get an object of Color Red
            var color1 = colorFactory.GetColor("RED");

            //call fill method of Red
            color1.Fill();

            //get an object of Color Green
            var color2 = colorFactory.GetColor("GREEN");

            //call fill method of Green
            color2.Fill();

            //get an object of Color Blue
            var color3 = colorFactory.GetColor("BLUE");

            //call fill method of Color Blue
            color3.Fill(); 
            #endregion

        }
    }
}
