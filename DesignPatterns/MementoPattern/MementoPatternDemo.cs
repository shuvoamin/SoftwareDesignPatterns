using System;
using System.Diagnostics;

namespace DesignPatterns.MementoPattern
{
    public class MementoPatternDemo
    {
        public Memento Memento
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CareTaker CareTaker
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var originator = new Originator();
            var careTaker = new CareTaker();

            originator.State = "State #1";
            originator.State = "State #2";
            careTaker.Add(originator.SaveStateToMemento());

            originator.State = "State #3";
            careTaker.Add(originator.SaveStateToMemento());

            originator.State = "State #4";
            Trace.WriteLine("Current State: " + originator.State + Environment.NewLine);

            originator.GetStateFromMemento(careTaker.Get(0));
            Trace.WriteLine("First saved State: " + originator.State + Environment.NewLine);
            originator.GetStateFromMemento(careTaker.Get(1));
            Trace.WriteLine("Second saved State: " + originator.State + Environment.NewLine);
        }
    }
}
