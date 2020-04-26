using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9Lab_Gajjar
{
    class Account
    {
        private int balance;
        public Account(int i)
        {
            balance = i;
        }
        public int getBalance()
        {
            return balance;
        }
        public void deposit(int i)
        {
            balance += i;
        }
        public void withdraw(int i)
        {
            balance -= i;
        }
    }
}
