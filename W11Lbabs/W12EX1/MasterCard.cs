using System;
using System.Collections.Generic;
using System.Text;

namespace W12EX1
{
    class MasterCard : CreditCard
    {
        public MasterCard(String cardNum, int expMM, int expYY)
        {
            this.cardNum = cardNum;
            this.expMM = expMM;
            this.expYY = expYY;
        }
        public override bool isNumOfDigitsValid()
        {
            if (cardNum.Length == 16)
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

            string validChars = "12345";



            if (prefix.Equals("5") && validChars.IndexOf(nextChar) >= 0)

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
