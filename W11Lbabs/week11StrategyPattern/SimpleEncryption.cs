using System;
using System.Collections.Generic;
using System.Text;

namespace week11StrategyPattern
{
    class SimpleEncryption: EncryptionStrategy
    {
       
        
 public String encrypt(String inputData)
        {
            inputData = inputData.Substring(inputData.Length - 1) +
            inputData.Substring(0, inputData.Length - 1);
            return inputData;
        }
    }
}
