using System;

namespace DesignPatterns.TemplatePattern
{
    public class TemplatePatternDemo
    {
        public Football Football
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public Cricket Cricket
        {
            get
            {
                throw new NotImplementedException();
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
