using System;

namespace W12EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard cc = new VisaCard("4234123412341232", 11, 2021);

            if (cc.isValid())
            { 
                Console.WriteLine("Valid Credit Card Information");
            }

            CreditCard mc = new MasterCard("5234123412341239", 11, 2021);

            if (mc.isValid())
            { 
                Console.WriteLine("Valid Master Card Information"); 
            }
            CreditCard ac = new AmexCard("30341234120410", 11, 2021);
            Console.ReadKey();

        }
    }

}
