using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern
{
    public class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();
        private int _state;

        public int State
        {
            get { return _state; }
            set 
            {
                _state = value;
                NotifyAllObservers();
            }
        }

        public Observer Observer
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

    }
}
