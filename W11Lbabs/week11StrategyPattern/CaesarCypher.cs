using System;
using System.Collections.Generic;
using System.Text;

namespace week11StrategyPattern
{
    class CaesarCypher: EncryptionStrategy
    {

        public String encrypt(String inputData)
        {
            char[] chars = inputData.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (c == 'z')
                {
                    c = 'a';
                }
                if ((c >= 'a') && (c < 'z'))
                {
                    ++c;
                }
                chars[i] = c;
            }
            return new String(chars);
        }
    }
}
