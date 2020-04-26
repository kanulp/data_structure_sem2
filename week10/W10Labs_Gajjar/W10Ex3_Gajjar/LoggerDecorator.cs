using System;
namespace W10Ex3_Gajjar
{
    public class LoggerDecorator : Logger
    {
        private Logger _logger;

        public LoggerDecorator(Logger logger)
        {
            _logger = logger;
        }

        public virtual void log(string logMessage)
        {
            _logger.log(logMessage);
        }
    }
}
