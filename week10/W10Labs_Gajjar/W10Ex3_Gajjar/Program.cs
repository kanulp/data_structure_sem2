using System;

namespace W10Ex3_Gajjar
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new LoggerFactory().getLogger(LoggerFactory.CONSOLE_LOGGER);
            HTMLLogger htmlLogger = new HTMLLogger(logger);
            htmlLogger.log("This is the message sent to html");
            htmlLogger.makeHTML("this is the message send to html");
            EncryptLogger encryptLogger = new EncryptLogger(logger);
            encryptLogger.log("this is the messag to encrypt logger");
            encryptLogger.encrypt("this is the message send to encrypt");

        }
    }
}
