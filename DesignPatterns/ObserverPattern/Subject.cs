using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class Subject
    {
        private List<Observer> _observers = new List<Observer>();
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
            set
            {
            }
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }

    }
}
