using System;
using System.Collections.Generic;
using System.Text;

namespace W12EX1
{
    abstract class CreditCard
    {

        public String cardNum;
        public int expYY;
        public int expMM;
       

     

        public abstract bool isNumOfDigitsValid();

        public abstract  bool isValidPrefix();

        public abstract  bool isAccountInGoodStand();



        public bool isValid()
        {
        

            if (isNumOfDigitsValid() && isExpDtValid() && isValidPrefix() && hasValidChars() && isValidCheckSum() && isAccountInGoodStand())
            {

                return true;

            }


            return false;
        }


        public bool isExpDtValid()
        {
            int mm = DateTime.Now.Month + 1;
            int yy = DateTime.Now.Year;
            bool result = (yy > expYY) || ((yy == expYY) && (mm > expMM));
            return (!result);
        }
        private bool hasValidChars()
        {
            string validChars = "0123456789";
            bool result = true;
            for (int i = 0; i < cardNum.Length; i++)
            {
                string hh = cardNum.Substring(i, 1);
                int aa = validChars.IndexOf(cardNum.Substring(i, 1));
                if (validChars.IndexOf(cardNum.Substring(i, 1)) < 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        private bool isValidCheckSum()
        {
                bool result = true;
                int sum = 0;
                int multiplier = 1;
                int strLen = cardNum.Length;
                for (int i = 0; i < strLen; i++)
                {
                    string digit = cardNum.Substring(strLen - i - 1, 1);
                    int currProduct = Convert.ToInt32(digit) * multiplier;
                    if (currProduct >= 10)
                        sum += (currProduct % 10) + 1;
                    else
                        sum += currProduct;
                    if (multiplier == 1)
                        multiplier++;
                    else
                        multiplier--;
                }
                if ((sum % 10) != 0)
                    result = false;
                return result;
            }

    }
}
