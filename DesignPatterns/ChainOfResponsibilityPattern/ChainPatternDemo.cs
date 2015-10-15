namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class ChainPatternDemo
    {
        public AbstractLogger AbstractLogger
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            AbstractLogger loggerChain = GetChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger._info,
               "This is an information.");

            loggerChain.LogMessage(AbstractLogger._debug,
               "This is an debug level information.");

            loggerChain.LogMessage(AbstractLogger._error,
               "This is an error information.");
        }

        private static AbstractLogger GetChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger._error);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger._debug);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger._info);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }
    }
}
