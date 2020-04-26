using System;
namespace W10Ex3_Gajjar
{
    public class FileLogger : Logger
    {
        public FileLogger()
        {
        }

        public void log(string logMessage)
        {
            Console.WriteLine(logMessage + " is logged into file");
        }
    }
}
