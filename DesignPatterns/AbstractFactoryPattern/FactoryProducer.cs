using DesignPatterns.FactoryPattern;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public AbstractFactory AbstractFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.Equals("SHAPE"))
            {
                return new AbstractShapeFactory();
            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
