namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public abstract class AbstractLogger
    {
        public static int Info = 1;
        public static int Debug = 2;
        public static int Error = 3;

        protected int Level;

        //next element in chain or responsibility
        protected AbstractLogger NextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            NextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (Level <= level)
            {
                Write(message);
            }
            if (NextLogger != null)
            {
                NextLogger.LogMessage(level, message);
            }
        }

        protected abstract void Write(string message);
    }
}
