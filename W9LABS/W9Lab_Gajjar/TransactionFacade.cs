using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9Lab_Gajjar
{

    class TransactionFacade
    {
        private static TransactionFacade obj;

        private  NewBankAccount bankAccnt;

        private TransactionFacade()
        {
            //Account opened with 100$
            bankAccnt = new NewBankAccount(100);
        }
        public static TransactionFacade getInstance()
        {
            if (obj == null)
            {
                obj = new TransactionFacade();
            }

            return obj;
        }


        public void Debit(int amount)
        {

            AtmAds ads = new AtmAds();
            ads.showAds();
            bankAccnt.debit(amount);

            AtmUserLog userLog = new AtmUserLog();
            userLog.SaveUserLog();

            AtmStatus atmstatus = new AtmStatus();
            atmstatus.SaveAtmStatus();

            Console.WriteLine("Account Balance is : " + bankAccnt.balance());
        }

        public void Credit(int amount)
        {
            AtmAds ads = new AtmAds();
            ads.showAds();
            bankAccnt.credit(amount);

            AtmUserLog userLog = new AtmUserLog();
            userLog.SaveUserLog();

            AtmStatus atmstatus = new AtmStatus();
            atmstatus.SaveAtmStatus();

            Console.WriteLine("Account Balance is : " + bankAccnt.balance());
        }

    }
}
