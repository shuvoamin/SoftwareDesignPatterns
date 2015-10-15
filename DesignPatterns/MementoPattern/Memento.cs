using System;

namespace DesignPatterns.MementoPattern
{
    public class Memento
    {
        private String _state;

        public Memento(String state)
        {
            _state = state;
        }

        public String State
        {
            get { return _state; }
        }

        public Originator Originator
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
