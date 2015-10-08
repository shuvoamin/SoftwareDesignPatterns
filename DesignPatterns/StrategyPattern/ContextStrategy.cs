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

        public MultiplyOperation MultiplyOperation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public SubstractOperation SubstractOperation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public AddOperation AddOperation
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
