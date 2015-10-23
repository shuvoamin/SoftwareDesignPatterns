namespace DesignPatterns.MementoPattern
{
    public class Originator
    {
        private string _state;

        public string State
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
