﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
    public interface IComputerPart
    {    
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
