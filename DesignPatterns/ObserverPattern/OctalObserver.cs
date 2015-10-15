using System;

namespace DesignPatterns.ObserverPattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        //Override
        public override void Update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(_subject.State, 8) + Environment.NewLine);
        }
    }
}
