#region Namespaces
using System;
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.BridgePattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.BusinessDelegatePattern;
using DesignPatterns.ChainOfResponsibilityPattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.CompositeEntityPattern;
using DesignPatterns.DataAccessObjectPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FacadePatter;
using DesignPatterns.FactoryPattern;
using DesignPatterns.FrontControllerPattern;
using DesignPatterns.InterceptingFilterPattern;
using DesignPatterns.InterpreterPattern;
using DesignPatterns.IteratorPattern;
using DesignPatterns.MediatorPattern;
using DesignPatterns.MementoPattern;
using DesignPatterns.MvcPattern;
using DesignPatterns.NullObjectPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.ProxyPattern;
using DesignPatterns.ServiceLocatorPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.StatePattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.TemplatePattern;
using DesignPatterns.TransferObjectPattern;
using DesignPatterns.VisitorPattern;
#endregion

namespace DesignPatterns.ConsoleApp.AppMain
{
    class MainProgram
    {
        static void Main()
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

            #region SeeOutput => DesignPatters.PrototypePattern.PrototypePatternOutput.txt
            //Assuming all the codes for this pattern are right see the output in text file located its code folder.

            //TODO: need to solve StackOverFlow exception
            //Console.WriteLine("========== PROTOTYPE PATTERN RESULT ===========" + Environment.NewLine);
            //PrototypePatternDemo.Output(); 
            #endregion

            //TODO: makes output messed, need to fix
            //Console.WriteLine("========== ADAPTER PATTERN RESULT ===========" + Environment.NewLine);
            //AdapterPatternDemo.Output();

            Console.WriteLine("========== BRIDGE PATTERN RESULT ===========" + Environment.NewLine);
            BridgePatternDemo.Output();

            //TODO: makes output messed, need to fix
            //Console.WriteLine("========== FILTER PATTERN RESULT ===========" + Environment.NewLine);
            //FilterPatternDemo.Output();

            //TODO: makes output messed, need to fix
            //Console.WriteLine("========== COMPOSITE PATTERN RESULT ===========" + Environment.NewLine);
            //CompositePatternDemo.Output();

            Console.WriteLine("========== DECORATOR PATTERN RESULT ===========" + Environment.NewLine);
            DecoratorPatternDemo.Output();

            Console.WriteLine("========== FACADE PATTERN RESULT ===========" + Environment.NewLine);
            FacadePatternDemo.Output();

            #region SeeOutput => DesignPatterns.FlyweightPattern.FlyweightPatternOutput.txt
            //the original implementation of this pattern done by Java HashMap which supports null keys
            //and adding duplicate keys. C# doesn't support this feature.
            //Assuming all the codes for this pattern are right see the output in text file located its code folder.

            //TODO: C# dictionary cannot add a null key and cannot assign a duplicate key => need to fix
            //Console.WriteLine("========== FLYWEIGHT PATTERN RESULT ===========" + Environment.NewLine);
            //FlyweightPatternDemo.Output(); 
            #endregion

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

            Console.WriteLine("========== STATE PATTERN RESULT ===========" + Environment.NewLine);
            StatePatternDemo.Output();

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

            Console.WriteLine("========== DATA ACCESS OBJECT PATTERN RESULT ===========" + Environment.NewLine);
            DaoPatternDemo.Output();

            Console.WriteLine("========== FRONT CONTROLLER PATTERN RESULT ===========" + Environment.NewLine);
            FrontControllerPatternDemo.Output();

            Console.WriteLine("========== INTERCEPTING FILTER PATTERN RESULT ===========" + Environment.NewLine);
            InterceptingFilterPatternDemo.Output();

            Console.WriteLine("========== SERVICE LOCATOR PATTERN RESULT ===========" + Environment.NewLine);
            ServiceLocatorPatternDemo.Output();

            Console.WriteLine("========== TRANSFER OBJECT PATTERN RESULT ===========" + Environment.NewLine);
            TransferObjectPatternDemo.Output();

            Console.WriteLine("=================== ROGRAM ENDS HERE ===================");
            Console.ReadKey();
        }
    }
}
