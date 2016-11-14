#region Namespaces
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.AdapterPattern;
using DesignPatterns.BridgePattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.BusinessDelegatePattern;
using DesignPatterns.ChainOfResponsibilityPattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.CompositeEntityPattern;
using DesignPatterns.CompositePattern;
using DesignPatterns.DataAccessObjectPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FacadePattern;
using DesignPatterns.FactoryPattern;
using DesignPatterns.FilterPattern;
using DesignPatterns.FlyweightPattern;
using DesignPatterns.FrontControllerPattern;
using DesignPatterns.InterceptingFilterPattern;
using DesignPatterns.InterpreterPattern;
using DesignPatterns.IteratorPattern;
using DesignPatterns.MediatorPattern;
using DesignPatterns.MementoPattern;
using DesignPatterns.MvcPattern;
using DesignPatterns.NullObjectPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.PrototypePattern;
using DesignPatterns.ProxyPattern;
using DesignPatterns.ServiceLocatorPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.StatePattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.TemplatePattern;
using DesignPatterns.TransferObjectPattern;
using DesignPatterns.VisitorPattern;
using System;
using System.Diagnostics;

#endregion

namespace DesignPatterns.ConsoleApp.AppMain
{
    class MainProgram
    {
        static void Main()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("SoftwareDesignPaternsOutput.log"));
            Trace.AutoFlush = true;
            Trace.Indent();
            Console.WriteLine("Output text file location ==> \n");
            Console.WriteLine("./SoftwareDesignPatterns/DesignPatterns.ConsoleApp/bin/Debug/SoftwareDesignPatternsOutput.log");
            Console.WriteLine("\nAlternatively, see the visual studio output window.");

            #region Writing All Output in Trace File
            Trace.WriteLine("=================== PROGRAM STARTS HERE ===================" + Environment.NewLine);

            Trace.WriteLine("========== FACTORY PATTERN RESULT ===========" + Environment.NewLine);
            FactoryPatternDemo.Output();

            Trace.WriteLine("========== ABSTRACT FACTORY PATTERN RESULT ===========" + Environment.NewLine);
            AbstractFactoryPatternDemo.Output();

            Trace.WriteLine("========== SINGLETON PATTERN RESULT ===========" + Environment.NewLine);
            SingletonPatternDemo.Output();

            Trace.WriteLine("========== BUILDER PATTERN RESULT ===========" + Environment.NewLine);
            BuilderPatternDemo.Output();

            Trace.WriteLine("========== PROTOTYPE PATTERN RESULT ===========" + Environment.NewLine);
            PrototypePatternDemo.Output();

            Trace.WriteLine("========== ADAPTER PATTERN RESULT ===========" + Environment.NewLine);
            AdapterPatternDemo.Output();

            Trace.WriteLine("========== BRIDGE PATTERN RESULT ===========" + Environment.NewLine);
            BridgePatternDemo.Output();

            Trace.WriteLine("========== FILTER PATTERN RESULT ===========" + Environment.NewLine);
            FilterPatternDemo.Output();

            Trace.WriteLine("========== COMPOSITE PATTERN RESULT ===========" + Environment.NewLine);
            CompositePatternDemo.Output();

            Trace.WriteLine("========== DECORATOR PATTERN RESULT ===========" + Environment.NewLine);
            DecoratorPatternDemo.Output();

            Trace.WriteLine("========== FACADE PATTERN RESULT ===========" + Environment.NewLine);
            FacadePatternDemo.Output();

            Trace.WriteLine("========== FLYWEIGHT PATTERN RESULT ===========" + Environment.NewLine);
            FlyweightPatternDemo.Output();

            Trace.WriteLine("========== PROXY PATTERN RESULT ===========" + Environment.NewLine);
            ProxyPatternDemo.Output();

            Trace.WriteLine("========== PROXY PATTERN RESULT ===========" + Environment.NewLine);
            ChainPatternDemo.Output();

            Trace.WriteLine("========== COMMAND PATTERN RESULT ===========" + Environment.NewLine);
            CommandPatternDemo.Output();

            Trace.WriteLine("========== INTERPRETER PATTERN RESULT ===========" + Environment.NewLine);
            InterpreterPatternDemo.Output();

            Trace.WriteLine("========== ITERATOR PATTERN RESULT ===========" + Environment.NewLine);
            IteratorPatternDemo.Output();

            Trace.WriteLine("========== MEDIATOR PATTERN RESULT ===========" + Environment.NewLine);
            MediatorPatternDemo.Output();

            Trace.WriteLine("========== MEMENTO PATTERN RESULT ===========" + Environment.NewLine);
            MementoPatternDemo.Output();

            Trace.WriteLine("========== OBSERVER PATTERN RESULT ===========" + Environment.NewLine);
            ObserverPatternDemo.Output();

            Trace.WriteLine("========== STATE PATTERN RESULT ===========" + Environment.NewLine);
            StatePatternDemo.Output();

            Trace.WriteLine("========== NULL OBJECT PATTERN RESULT ===========" + Environment.NewLine);
            NullPatternDemo.Output();

            Trace.WriteLine("========== STRATEGY PATTERN RESULT ===========" + Environment.NewLine);
            StrategyPatternDemo.Output();

            Trace.WriteLine("========== TEMPLATE PATTERN RESULT ===========" + Environment.NewLine);
            TemplatePatternDemo.Output();

            Trace.WriteLine("========== VISITOR PATTERN RESULT ===========" + Environment.NewLine);
            VisitorPatternDemo.Output();

            Trace.WriteLine("========== MVC PATTERN RESULT ===========" + Environment.NewLine);
            MvcPatternDemo.Output();

            Trace.WriteLine("========== BUSINESS DELEGATE PATTERN RESULT ===========" + Environment.NewLine);
            BusinessDelegatePatternDemo.Output();

            Trace.WriteLine("========== COMPOSITE ENTITY PATTERN RESULT ===========" + Environment.NewLine);
            CompositeEntityPatternDemo.Output();

            Trace.WriteLine("========== DATA ACCESS OBJECT PATTERN RESULT ===========" + Environment.NewLine);
            DaoPatternDemo.Output();

            Trace.WriteLine("========== FRONT CONTROLLER PATTERN RESULT ===========" + Environment.NewLine);
            FrontControllerPatternDemo.Output();

            Trace.WriteLine("========== INTERCEPTING FILTER PATTERN RESULT ===========" + Environment.NewLine);
            InterceptingFilterPatternDemo.Output();

            Trace.WriteLine("========== SERVICE LOCATOR PATTERN RESULT ===========" + Environment.NewLine);
            ServiceLocatorPatternDemo.Output();

            Trace.WriteLine("========== TRANSFER OBJECT PATTERN RESULT ===========" + Environment.NewLine);
            TransferObjectPatternDemo.Output();

            Trace.WriteLine("=================== ROGRAM ENDS HERE ===================");
            #endregion

            Trace.Unindent();
            Trace.Flush();
            Console.ReadKey();
        }
    }
}
