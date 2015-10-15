using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.InterpreterPattern
{
    public class AndExpression : IExpression
    {
        private IExpression _expr1 = null;
        private IExpression _expr2 = null;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public IExpression IExpression
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        //Override
        public Boolean Interpret(string context)
        {
            return _expr1.Interpret(context) && _expr2.Interpret(context);
        }
    }
}
