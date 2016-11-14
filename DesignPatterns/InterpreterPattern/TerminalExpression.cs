using DesignPatterns.Interfaces;

namespace DesignPatterns.InterpreterPattern
{
    public class TerminalExpression : IExpression
    {
        private readonly string _data;

        public TerminalExpression(string data)
        {
            _data = data;
        }

        public IExpression Expression
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        //Override
        public bool Interpret(string context)
        {
            return context.Contains(_data);
        }
    }
}
