using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.IteratorPattern
{
    public class NameRepository : IContainer
    {
        public static String[] _names = { "Robert", "John", "Julie", "Laura" };

        public IContainer IContainer
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public IIterator IIterator
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
                if (_index < _names.Length)
                {
                    return true;
                }

                return false;
            }

            //Override
            public object Next()
            {
                if (HasNext())
                {
                    return _names[_index++];
                }

                return null;
            }
        }
    }
}
