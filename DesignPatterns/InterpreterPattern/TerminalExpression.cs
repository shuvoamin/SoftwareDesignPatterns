using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.InterpreterPattern
{
    public class TerminalExpression : IExpression
    {
        private string _data;

        public TerminalExpression(string data)
        {
            _data = data;
        }

        public DesignPatterns.Interfaces.IExpression IExpression
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //Override
        public bool Interpret(string context)
        {
            if (context.Contains(_data))
            {
                return true;
            }

            return false;
        }
    }
}
