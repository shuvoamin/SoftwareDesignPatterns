using System;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public abstract class AbstractLogger
    {
        public static int _info = 1;
        public static int _debug = 2;
        public static int _error = 3;

        protected int _level;

        //next element in chain or responsibility
        protected AbstractLogger _nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            _nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (_level <= level)
            {
                Write(message);
            }
            if (_nextLogger != null)
            {
                _nextLogger.LogMessage(level, message);
            }
        }

        protected abstract void Write(String message);
    }
}
