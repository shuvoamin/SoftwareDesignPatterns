using DesignPatterns.Interfaces;

namespace DesignPatterns.BuilderPattern
{
    public class Wrapper : IPacking
    {
        public IPacking IPacking
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
        public string pack()
        {
            return "Wrapper";
        }
    }
}
