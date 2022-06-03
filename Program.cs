using ChainResponsibility;

Logger logger = Logger.GetLoggerConfiguration();

logger.LogMessage(Logger.ERROR, "Something wrong with server");
logger.LogMessage(Logger.WARNING, "Value logger can be null");
logger.LogMessage(Logger.INFO, "Statement can be simplified");