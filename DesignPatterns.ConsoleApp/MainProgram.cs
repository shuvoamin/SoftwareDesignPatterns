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

            Console.WriteLine("=========== PROGRAM ENDS HERE ============");
            Console.ReadKey();
        }
    }
}
