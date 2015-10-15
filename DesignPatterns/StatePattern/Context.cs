using DesignPatterns.Interfaces;

namespace DesignPatterns.StatePattern
{
    public class Context
    {
        private IState _state;

        public Context()
        {
            _state = null;
        }

        public IState State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
