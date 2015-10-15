﻿using DesignPatterns.Interfaces;

namespace DesignPatterns.VisitorPattern
{
    public class Monitor : IComputerPart
    {
        public IComputerPart IComputerPart
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
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
