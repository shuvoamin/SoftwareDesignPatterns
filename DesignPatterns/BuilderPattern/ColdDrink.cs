using DesignPatterns.Interfaces;

namespace DesignPatterns.BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public Bottle Bottle
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public IItem Item
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        //Override
        public abstract string name();

        //Override
        public IPacking packing()
        {
            return new Bottle();
        }

        //Override
        public abstract float price();
    }
}
