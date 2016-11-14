namespace DesignPatterns.MementoPattern
{
    public class Originator
    {
        public string State { get; set; }

        public Memento SaveStateToMemento()
        {
            return new Memento(State);
        }

        public void GetStateFromMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}
