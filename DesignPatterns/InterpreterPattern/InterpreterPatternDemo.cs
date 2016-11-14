using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

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
        }

        public AndExpression AndExpression
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public OrExpression OrExpression
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var isMale = GetMaleExpression();
            var isMarriedWoman = GetMarriedWomanExpression();

            Trace.WriteLine("John is male? " + isMale.Interpret("John") + Environment.NewLine);
            Trace.WriteLine("Julie is a married women? " + isMarriedWoman.Interpret("Married Julie") + Environment.NewLine);
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
