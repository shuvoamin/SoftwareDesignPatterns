using DesignPatterns.Interfaces;

namespace DesignPatterns.BuilderPattern
{
    public class Wrapper : IPacking
    {
        public IPacking Packing
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        //Override
        public string pack()
        {
            return "Wrapper";
        }
    }
}
