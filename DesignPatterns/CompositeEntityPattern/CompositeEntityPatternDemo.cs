﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositeEntityPattern
{
    public class CompositeEntityPatternDemo
    {
        public ClientComposite ClientComposite
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
            ClientComposite client = new ClientComposite();
            client.SetData("Test", "Data");
            client.PrintData();
            client.SetData("Second Test", "Data1");
            client.PrintData();
        }
    }
}