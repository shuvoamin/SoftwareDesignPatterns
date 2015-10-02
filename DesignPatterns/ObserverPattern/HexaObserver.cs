using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        //Override
        public override void Update()
        {
            Console.WriteLine("Hex String: " + _subject.State.ToString("X1") + Environment.NewLine);
        }
    }
}
