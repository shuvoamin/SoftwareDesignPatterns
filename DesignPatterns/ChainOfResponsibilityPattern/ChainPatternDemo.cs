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
        }
    
        public static void Output()
        {
            AbstractLogger loggerChain = GetChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger.Info,
               "This is an information.");

            loggerChain.LogMessage(AbstractLogger.Debug,
               "This is an debug level information.");

            loggerChain.LogMessage(AbstractLogger.Error,
               "This is an error information.");
        }

        private static AbstractLogger GetChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.Error);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.Debug);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.Info);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }
    }
}
