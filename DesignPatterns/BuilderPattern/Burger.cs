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
        public abstract string Name();

        //Override
        public IPacking Packing()
        {
            return new Wrapper();
        }

        //Override
        public abstract float Price();
    }
}
