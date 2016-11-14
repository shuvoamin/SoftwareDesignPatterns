using System;
using System.Diagnostics;

namespace DesignPatterns.TemplatePattern
{
    public class Football : Game
    {
        //Override
        public override void Initialize()
        {
            Trace.WriteLine("Footbal Game Initialized! Start Playing." + Environment.NewLine);
        }

        //Override
        public override void StartPlay()
        {
            Trace.WriteLine("Footbal Game Started. Enjoy the Game!" + Environment.NewLine);
        }

        //Override
        public override void EndPlay()
        {
            Trace.WriteLine("Footbal Game Finished!" + Environment.NewLine);
        }
    }
}
