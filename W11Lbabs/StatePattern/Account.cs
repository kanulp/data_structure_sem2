using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Account
    {
        public static readonly double MIN_BALANCE = 2000.00;
          public static readonly double OVERDRAW_LIMIT = -1000.00;

          public static readonly double TRANS_FEE_NORMAL = 2.00;
          public static readonly double TRANS_FEE_OVERDRAW = 5.00;

          public static readonly string ERR_OVERDRAW_LIMIT_EXCEED =
            "Error: Transaction cannot be processed. " + 
              "Overdraw limit exceeded.";


          private State objState;
          private string accountNumber;
          private double balance;

          public void setState(State newState) {
            objState = newState;
          }
          public State getState() {
            return objState;
          }

          public string getAccountNumber() {
            return accountNumber;
          }

          public bool deposit(double amount) {
            return getState().deposit(amount);
          }
          public bool withdraw(double amount) {
            return getState().withdraw(amount);
          }
          public Account(String accountNum) {
            accountNumber = accountNum;
            objState = State.InitialState(this);
          }
          public double getBalance() {
            return balance;
          }

          public void setBalance(double newBalance) {
            balance = newBalance;
          }

    }
}
