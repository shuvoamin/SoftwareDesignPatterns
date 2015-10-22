using System;

namespace DesignPatterns.ObserverPattern
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            Subject = subject;
            Subject.Attach(this);
        }

        //Override
        public override void Update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(Subject.State, 2) + Environment.NewLine);
        }
    }
}
