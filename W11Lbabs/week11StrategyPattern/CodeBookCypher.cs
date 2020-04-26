using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace week11StrategyPattern
{
    class CodeBookCypher: EncryptionStrategy
    {

        Hashtable codeContents = new Hashtable();
        private void populateCodeEntries()
        {
            codeContents.Add("This", "Design");
            codeContents.Add("is", "Patterns");
            codeContents.Add("a", "are");
            codeContents.Add("true", "really");
            codeContents.Add("statement", "useful");
        }
        public string encrypt(string inputData)
        {
            populateCodeEntries();
            String outStr = "";

            string[] st = inputData.Split(' ');
            foreach (var item in st)
            {
                outStr = outStr + " " + codeContents[item];
            }
            return outStr;
        }

    }
}
