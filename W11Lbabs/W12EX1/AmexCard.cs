using System;
using System.Collections.Generic;
using System.Text;

namespace W12EX1
{
    class AmexCard : CreditCard
    {
        public AmexCard(String cardNum, int expMM, int expYY)
        {
            this.cardNum = cardNum;
            this.expMM = expMM;
            this.expYY = expYY;
        }

        public override bool isNumOfDigitsValid()
        {
            if (cardNum.Length == 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool isValidPrefix()
        {
            string prefix = cardNum.Substring(0, 1);
            string nextChar = cardNum.Substring(1, 2);
            string validChars = "068";
            if (prefix.Equals("3") && validChars.IndexOf(nextChar) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool isAccountInGoodStand()
        {
            return true;
        }

    }
}
