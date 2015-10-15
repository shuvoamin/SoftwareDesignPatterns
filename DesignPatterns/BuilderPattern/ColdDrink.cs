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
            set
            {
            }
        }

        public DesignPatterns.Interfaces.IItem IItem
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
