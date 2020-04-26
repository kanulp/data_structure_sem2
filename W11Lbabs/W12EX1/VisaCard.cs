using System;
using System.Collections.Generic;
using System.Text;

namespace W12EX1
{
    //Karan Gajjar
    class VisaCard: CreditCard
    {

        public VisaCard(String cardNum, int expMM, int expYY)
        {
            this.cardNum = cardNum;
            this.expMM = expMM;
            this.expYY = expYY;
        }
        public override bool isNumOfDigitsValid()

        {

            if ((cardNum.Length == 13) || (cardNum.Length == 16) )
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
            if (prefix.Equals("4"))
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
