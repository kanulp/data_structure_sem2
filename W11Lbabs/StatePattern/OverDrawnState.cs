using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class OverDrawnState : State
    {

        public void sendMailToAccountHolder()
        {
            Console.WriteLine("Attention: Your Account is Overdrawn");
        }

        public OverDrawnState(Account account): base(account)
        {
            sendMailToAccountHolder();
        }
        public OverDrawnState(State source): base(source)
        {
            sendMailToAccountHolder();
        }

        public override State transitionState()
        {
            double balance = getContext().getBalance();
            if (balance >= Account.MIN_BALANCE)
                getContext().setState(
                  new NoTransactionFeeState(this));
            else if (balance >= 0)
                getContext().setState(new TransactionFeeState(this));
            return getContext().getState();
        }

        public override bool deposit(double amount)
        {
            double balance = getContext().getBalance();

            getContext().setBalance(balance -  Account.TRANS_FEE_OVERDRAW);
            Console.WriteLine("Transaction Fee was charged " + "due to account status(Overdrawn)");
            return base.deposit(amount);
        }

        public override bool withdraw(double amount)
        {
            double balance = getContext().getBalance();

            if ((balance - Account.TRANS_FEE_OVERDRAW - amount) > Account.OVERDRAW_LIMIT)
            {

                getContext().setBalance(balance -
                    Account.TRANS_FEE_OVERDRAW);
                Console.WriteLine(
                  "Transaction Fee was charged due to " +
                  "account status(Overdrawn)");
                return base.withdraw(amount);

            }
            else
            {
                Console.WriteLine(
                  Account.ERR_OVERDRAW_LIMIT_EXCEED);
                return false;
            }
        }

    }

}
