using System;

namespace DesignPatterns.ObserverPattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            Subject = subject;
            Subject.Attach(this);
        }

        //Override
        public override void Update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(Subject.State, 8) + Environment.NewLine);
        }
    }
}
