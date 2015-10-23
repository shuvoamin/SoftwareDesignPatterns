using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.InterpreterPattern
{
    public class AndExpression : IExpression
    {
        private readonly IExpression _expr1;
        private readonly IExpression _expr2;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public IExpression Expression
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public bool Interpret(string context)
        {
            return _expr1.Interpret(context) && _expr2.Interpret(context);
        }
    }
}
