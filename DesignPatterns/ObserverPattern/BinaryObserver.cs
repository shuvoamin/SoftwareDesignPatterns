using DesignPatterns.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MementoPattern
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        //Override
        public override void Update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(_subject.State, 2) + Environment.NewLine);
        }
    }
}
