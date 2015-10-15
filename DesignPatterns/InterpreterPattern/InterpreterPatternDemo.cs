using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.InterpreterPattern
{
    public class InterpreterPatternDemo
    {
        public TerminalExpression TerminalExpression
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public AndExpression AndExpression
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public OrExpression OrExpression
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            IExpression isMale = GetMaleExpression();
            IExpression isMarriedWoman = GetMarriedWomanExpression();

            Console.WriteLine("John is male? " + isMale.Interpret("John") + Environment.NewLine);
            Console.WriteLine("Julie is a married women? " + isMarriedWoman.Interpret("Married Julie") + Environment.NewLine);
        }

        //Rule: Robert and John are male
        public static IExpression GetMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        //Rule: Julie is a married women
        public static IExpression GetMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
    }
}
