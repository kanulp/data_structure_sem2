using System;
namespace W10Ex2_Gajjar
{
    public class ConsoleLogger: Logger
    {
        public ConsoleLogger()
        {
        }

        public void log(string logMessage)
        {
            Console.WriteLine(logMessage + " is logged into console.");
        }
    }
}
