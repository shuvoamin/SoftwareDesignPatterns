using System;

namespace DesignPatterns.Interfaces
{
    public interface IExpression
    {
        Boolean Interpret(string context);
    }
}
