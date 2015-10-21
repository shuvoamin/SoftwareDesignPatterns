using DesignPatterns.Interfaces;

namespace DesignPatterns.BuilderPattern
{
    public abstract class Burger : IItem
    {
        public Wrapper Wrapper
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
            return new Wrapper();
        }

        //Override
        public abstract float price();
    }
}
