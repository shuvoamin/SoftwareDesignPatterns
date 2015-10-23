using DesignPatterns.Interfaces;

namespace DesignPatterns.StatePattern
{
    public class Context
    {
        public Context()
        {
            State = null;
        }

        public IState State { get; set; }
    }
}
