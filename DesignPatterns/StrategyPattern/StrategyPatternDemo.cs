using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class StrategyPatternDemo
    {
        public ContextStrategy ContextStrategy
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
            ContextStrategy context = new ContextStrategy(new AddOperation());
            Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5) + Environment.NewLine);

            context = new ContextStrategy(new SubstractOperation());
            Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5) + Environment.NewLine);

            context = new ContextStrategy(new MultiplyOperation());
            Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5) + Environment.NewLine);
        }
    }
}
