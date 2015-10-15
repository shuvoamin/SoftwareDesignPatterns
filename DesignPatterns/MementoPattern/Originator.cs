using System;

namespace DesignPatterns.MementoPattern
{
    public class Originator
    {
        private String _state;

        public String State
        {
            get { return _state; }
            set { _state = value; }
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(_state);
        }

        public void GetStateFromMemento(Memento memento)
        {
            _state = memento.State;
        }
    }
}
