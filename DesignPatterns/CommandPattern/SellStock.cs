﻿using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class SellStock : IOrder
    {
        private Stock _abcStock;

        public SellStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public DesignPatterns.Interfaces.IOrder IOrder
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
        public void Execute()
        {
            _abcStock.Sell();
        }
    }
}