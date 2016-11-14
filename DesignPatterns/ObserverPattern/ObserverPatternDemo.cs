using System;
using System.Diagnostics;

namespace DesignPatterns.ObserverPattern
{
    public class ObserverPatternDemo
    {
        public Subject Subject
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public OctalObserver OctalObserver
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public HexaObserver HexaObserver
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BinaryObserver BinaryObserver
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Trace.WriteLine("First state change: 15" + Environment.NewLine);
            subject.State = 15;
            Trace.WriteLine("Second state change: 10" + Environment.NewLine);
            subject.State = 10;
        }
    }
}
