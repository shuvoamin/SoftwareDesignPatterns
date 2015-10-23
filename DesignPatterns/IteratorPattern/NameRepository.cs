using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.IteratorPattern
{
    public class NameRepository : IContainer
    {
        public static string[] Names = { "Robert", "John", "Julie", "Laura" };

        public IContainer Container
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IIterator Iterator
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public IIterator GetIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {
            int _index;

            //Override
            public bool HasNext()
            {
                return _index < Names.Length;
            }

            //Override
            public object Next()
            {
                return HasNext() ? Names[_index++] : null;
            }
        }
    }
}
