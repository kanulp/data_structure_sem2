using System;
using System.Collections.Generic;
using System.Text;

namespace week11StrategyPattern
{
    interface EncryptionStrategy
    {

        public string encrypt(string inputData);

    }
}
