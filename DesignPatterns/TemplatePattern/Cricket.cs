using System;

namespace DesignPatterns.TemplatePattern
{
    public class Cricket : Game
    {
        //Override
        public override void Initialize()
        {
            Console.WriteLine("Cricket Game Initialized! Start Playing." + Environment.NewLine);
        }

        //Override
        public override void StartPlay()
        {
            Console.WriteLine("Cricket Game Started. Enjoy the Game!" + Environment.NewLine);
        }

        //Override
        public override void EndPlay()
        {
            Console.WriteLine("Cricket Game Finished!" + Environment.NewLine);
        }
    }
}
