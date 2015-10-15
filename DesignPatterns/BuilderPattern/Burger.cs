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
            return new Wrapper();
        }

        //Override
        public abstract float price();
    }
}
