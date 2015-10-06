using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplatePattern
{
    public class Football : Game
    {
        //Override
        public override void Initialize()
        {
            Console.WriteLine("Footbal Game Initialized! Start Playing." + Environment.NewLine);
        }

        //Override
        public override void StartPlay()
        {
            Console.WriteLine("Footbal Game Started. Enjoy the Game!" + Environment.NewLine);
        }

        //Override
        public override void EndPlay()
        {
            Console.WriteLine("Footbal Game Finished!" + Environment.NewLine);
        }
    }
}
