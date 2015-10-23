using System;
using System.Diagnostics;

namespace DesignPatterns.TemplatePattern
{
    public class Cricket : Game
    {
        //Override
        public override void Initialize()
        {
            Trace.WriteLine("Cricket Game Initialized! Start Playing." + Environment.NewLine);
        }

        //Override
        public override void StartPlay()
        {
            Trace.WriteLine("Cricket Game Started. Enjoy the Game!" + Environment.NewLine);
        }

        //Override
        public override void EndPlay()
        {
            Trace.WriteLine("Cricket Game Finished!" + Environment.NewLine);
        }
    }
}
