﻿#region Namespaces
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
using DesignPatterns.FlyweightPattern;
using DesignPatterns.ProxyPattern;
using DesignPatterns.ChainOfResponsibilityPattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.InterpreterPattern;
using DesignPatterns.IteratorPattern;
using DesignPatterns.MediatorPattern;
using DesignPatterns.MementoPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.StatePattern;
using DesignPatterns.NullObjectPattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.TemplatePattern;
using DesignPatterns.VisitorPattern;
using DesignPatterns.BusinessDelegatePattern;
using DesignPatterns.CompositeEntityPattern; 
#endregion

namespace DesignPatterns.ConsoleApp
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== PROGRAM STARTS HERE ===================" + Environment.NewLine);

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

            //TODO: dictionary cannot return null => need to fix
            //Console.WriteLine("========== FLYWEIGHT PATTERN RESULT ===========" + Environment.NewLine);
            //FlyweightPatternDemo.Output();

            Console.WriteLine("========== PROXY PATTERN RESULT ===========" + Environment.NewLine);
            ProxyPatternDemo.Output();

            Console.WriteLine("========== PROXY PATTERN RESULT ===========" + Environment.NewLine);
            ChainPatternDemo.Output();

            Console.WriteLine("========== COMMAND PATTERN RESULT ===========" + Environment.NewLine);
            CommandPatternDemo.Output();

            Console.WriteLine("========== INTERPRETER PATTERN RESULT ===========" + Environment.NewLine);
            InterpreterPatternDemo.Output();

            Console.WriteLine("========== ITERATOR PATTERN RESULT ===========" + Environment.NewLine);
            IteratorPatternDemo.Output();

            Console.WriteLine("========== MEDIATOR PATTERN RESULT ===========" + Environment.NewLine);
            MediatorPatternDemo.Output();

            Console.WriteLine("========== MEMENTO PATTERN RESULT ===========" + Environment.NewLine);
            MementoPatternDemo.Output();

            Console.WriteLine("========== OBSERVER PATTERN RESULT ===========" + Environment.NewLine);
            ObserverPatternDemo.Output();

            //TODO: output not as expected
            //Console.WriteLine("========== STATE PATTERN RESULT ===========" + Environment.NewLine);
            //StatePatternDemo.Output();

            Console.WriteLine("========== NULL OBJECT PATTERN RESULT ===========" + Environment.NewLine);
            NullPatternDemo.Output();

            Console.WriteLine("========== STRATEGY PATTERN RESULT ===========" + Environment.NewLine);
            StrategyPatternDemo.Output();

            Console.WriteLine("========== TEMPLATE PATTERN RESULT ===========" + Environment.NewLine);
            TemplatePatternDemo.Output();

            Console.WriteLine("========== VISITOR PATTERN RESULT ===========" + Environment.NewLine);
            VisitorPatternDemo.Output();

            Console.WriteLine("========== MVC PATTERN RESULT ===========" + Environment.NewLine);
            MvcPatternDemo.Output();

            Console.WriteLine("========== BUSINESS DELEGATE PATTERN RESULT ===========" + Environment.NewLine);
            BusinessDelegatePatternDemo.Output();

            Console.WriteLine("========== COMPOSITE ENTITY PATTERN RESULT ===========" + Environment.NewLine);
            CompositeEntityPatternDemo.Output();

            Console.WriteLine("=================== ROGRAM ENDS HERE ===================");
            Console.ReadKey();
        }
    }
}
