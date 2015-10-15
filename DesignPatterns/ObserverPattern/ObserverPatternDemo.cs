using System;

namespace DesignPatterns.ObserverPattern
{
    public class ObserverPatternDemo
    {
        public Subject Subject
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public OctalObserver OctalObserver
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public BinaryObserver BinaryObserver
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public HexaObserver HexaObserver
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15" + Environment.NewLine);
            subject.State = 15;
            Console.WriteLine("Second state change: 10" + Environment.NewLine);
            subject.State = 10;
        }
    }
}
