using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class ContextStrategy
    {
        private IStrategy _strategy;

        public ContextStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public DesignPatterns.Interfaces.IStrategy IStrategy
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return _strategy.DoOperation(num1, num2);
        }
    }
}
