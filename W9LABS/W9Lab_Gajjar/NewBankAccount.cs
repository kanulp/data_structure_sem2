using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9Lab_Gajjar
{
    class NewBankAccount:IBankAccount
    {

        private Account accountInfo;

        public NewBankAccount(int amount)
        {
            this.accountInfo = new Account(amount);
        }

        public int balance()
        {
            return accountInfo.getBalance();
        }

        public void credit(int amount)
        {
            accountInfo.deposit(amount);
        }

        public void debit(int amount)
        {
            accountInfo.withdraw(amount);
        }


    }
        public class AtmAds
        {
            public void showAds()
            {
                Console.WriteLine("Showing ads....");
            }
        }
        public class AtmStatus
        {
            public void SaveAtmStatus()
            {
                Console.WriteLine("Saved ATM Status....");
            }
        }
        public class AtmUserLog
        {
            public void SaveUserLog()
            {
                Console.WriteLine("Saved User logs....");
            }
        }


    }

