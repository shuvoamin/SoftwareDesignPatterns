using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.SingletonPattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.PrototypePattern;
using DesignPatterns.AdapterPattern;
using DesignPatterns.MvcPattern;
using DesignPatterns.BridgePattern;
using DesignPatterns.FilterPattern;
using DesignPatterns.CompositePattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FacadePatter;

namespace DesignPatterns.ConsoleApp
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== FACTORY PATTERN RESULT ===========" + Environment.NewLine);
            FactoryPatternDemo.Output();

            Console.WriteLine("========== ABSTRACT FACTORY PATTERN RESULT ===========" + Environment.NewLine);
            AbstractFactoryPatternDemo.Output();

            Console.WriteLine("========== SINGLETON PATTERN RESULT ===========" + Environment.NewLine);
            SingletonPatternDemo.Output();

            Console.WriteLine("========== BUILDER PATTERN RESULT ===========" + Environment.NewLine);
            BuilderPatternDemo.Output();

            //TODO: need to solve StackOverFlow exception
            //Console.WriteLine("========== PROTOTYPE PATTERN RESULT ===========" + Environment.NewLine);
            //PrototypePatternDemo.Output();

            Console.WriteLine("========== ADAPTER PATTERN RESULT ===========" + Environment.NewLine);
            AdapterPatternDemo.Output();

            Console.WriteLine("========== BRIDGE PATTERN RESULT ===========" + Environment.NewLine);
            BridgePatternDemo.Output();

            Console.WriteLine("========== FILTER PATTERN RESULT ===========" + Environment.NewLine);
            FilterPatternDemo.Output();

            //TODO: Output not working as expected
            //Console.WriteLine("========== COMPOSITE PATTERN RESULT ===========" + Environment.NewLine);
            //CompositePatternDemo.Output();

            Console.WriteLine("========== DECORATOR PATTERN RESULT ===========" + Environment.NewLine);
            DecoratorPatternDemo.Output();

            Console.WriteLine("========== FACADE PATTERN RESULT ===========" + Environment.NewLine);
            FacadePatternDemo.Output();

            Console.WriteLine("========== MVC PATTERN RESULT ===========" + Environment.NewLine);
            MvcPatternDemo.Output();

            Console.WriteLine("=========== PROGRAM ENDS HERE ============");
            Console.ReadKey();
        }
    }
}
