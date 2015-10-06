using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplatePattern
{
    public class TemplatePatternDemo
    {
        public Football Football
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Cricket Cricket
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
            Game game = new Cricket();
            game.Play();
            Console.WriteLine(Environment.NewLine);
            game = new Football();
            game.Play();
        }
    }
}
