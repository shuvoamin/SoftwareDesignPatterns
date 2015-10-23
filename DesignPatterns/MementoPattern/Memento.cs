using System;

namespace DesignPatterns.MementoPattern
{
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string State
        {
            get { return _state; }
        }

        public Originator Originator
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
    }
}
