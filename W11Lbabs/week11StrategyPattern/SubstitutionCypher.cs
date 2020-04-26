using System;
using System.Collections.Generic;
using System.Text;

namespace week11StrategyPattern
{
    class SubstitutionCypher: EncryptionStrategy
    {
        char[] source = {'a','b','c','d','e','f','g','h','i','j','k',
 'l','m','n','o','p','q','r','s','t','u','v',
 'w','x','y','z'};
        char[] dest = {'m','n','o','p','q','r','a','b','c','d','e',
 'f','g','h','i','j','k','l','y','z','s','t',
 'u','v','w', 'x'};
        public String encrypt(String inputData)
        {
            char[] chars = inputData.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                for (int j = 0; j < source.Length; j++)
                {
                    if (source[j] == chars[i])
                    {
                        c = dest[j];
                    }
                }
                chars[i] = c;
            }
            return new String(chars);
        }

    }
}
