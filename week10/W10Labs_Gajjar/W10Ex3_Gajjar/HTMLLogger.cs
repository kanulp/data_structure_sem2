using System;
namespace W10Ex3_Gajjar
{
    public class HTMLLogger : LoggerDecorator
    {
        public HTMLLogger(Logger logger): base(logger)
        {

        }

        public override void log(string logMessage)
        {
            base.log(logMessage);
        }

        public void makeHTML(string dataLine)
        {
            Console.WriteLine("HTML:  " + dataLine);

        }
    }
}
