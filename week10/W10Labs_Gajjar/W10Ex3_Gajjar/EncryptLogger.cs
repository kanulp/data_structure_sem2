using System;
namespace W10Ex3_Gajjar
{
    public class EncryptLogger : LoggerDecorator
    {
        public EncryptLogger(Logger logger) : base(logger)
        {
        }

        public void encrypt(string dataLine)
        {
            Console.WriteLine("Encrypting: " + dataLine);
        }

    }
}
