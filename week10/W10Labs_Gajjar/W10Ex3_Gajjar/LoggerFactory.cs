using System;
namespace W10Ex3_Gajjar
{
    public class LoggerFactory
    {

        public static string FILE_LOGGER = "FILE_LOGGER";
        public static string CONSOLE_LOGGER = "CONSOLE_LOGGER";

        public Logger getLogger(string type)
        {
            if (type.Equals(FILE_LOGGER)){
                return new FileLogger();
            }
            else
            {
                return new ConsoleLogger();
            }

        }
    }
}
