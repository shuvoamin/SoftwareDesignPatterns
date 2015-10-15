using System;

namespace DesignPatterns.Interfaces
{
    public interface IIterator
    {
        Boolean HasNext();
        Object Next();
    }
}
