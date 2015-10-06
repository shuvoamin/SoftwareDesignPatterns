using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class SubstractOperation : IStrategy
    {
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
        //Override
        public int DoOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
