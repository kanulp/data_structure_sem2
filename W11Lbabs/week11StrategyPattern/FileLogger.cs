using System;
using System.Collections.Generic;
using System.Text;

namespace week11StrategyPattern
{
    class FileLogger
    {
        public void log(String fileName, String msg)
        {
            Console.WriteLine("Writing following message to a the file {0}\n{1}", fileName, msg);
        }
    }
}
