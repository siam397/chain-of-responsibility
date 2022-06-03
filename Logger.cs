namespace ChainResponsibility
{
    public abstract class Logger
    {
        public static int ERROR = 3;
        public static int WARNING = 2;
        public static int INFO = 1;
        protected int _level;
        protected Logger _nextLogger;

        public void setNextLogger(Logger logger)
        {
            _nextLogger = logger;
        }

        public static Logger GetLoggerConfiguration()
        {
            Logger errorLogger = new ErrorLogger(ERROR);
            Logger warnLogger=new WarnLogger(WARNING);
            Logger infoLogger=new InfoLogger(INFO);

            errorLogger.setNextLogger(warnLogger);
            warnLogger.setNextLogger(infoLogger);
            return errorLogger;
        }

        public void LogMessage(int level, string message)
        {
            if(_level <= level)
            {
                Write(message);
            }
            if (_nextLogger != null)
            {
                _nextLogger.LogMessage(level,message);
            }
        }

        public abstract void Write(string message);
    }
}
