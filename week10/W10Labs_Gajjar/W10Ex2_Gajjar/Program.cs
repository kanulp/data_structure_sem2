using System;

namespace W10Ex2_Gajjar
{
    class Program
    {
       public static void Main(string[] args)
        {
            Logger logger = new FileLogger();
            logger.log("this is the first message");

            Logger logger2 = new ConsoleLogger();
            logger2.log("this is the second message");
        }
    }
}
