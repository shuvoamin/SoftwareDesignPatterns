﻿using DesignPatterns.Interfaces;

namespace DesignPatterns.StrategyPattern
{
    public class SubstractOperation : IStrategy
    {
        public IStrategy Strategy
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        //Override
        public int DoOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
