using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class State
    {
        private Account context;

        public Account getContext()
        {
            return context;
        }

        public void setContext(Account newAccount)
        {
            context = newAccount;
        }

        public virtual State transitionState()
        {
            return null;
        }

        public State(Account account)
        {
            setContext(account);
        }

        public State(State source)
        {
            setContext(source.getContext());
        }

        public static State InitialState(Account account)
        {
            return new NoTransactionFeeState(account);
        }

        public virtual bool deposit(double amount)
        {
            double balance = getContext().getBalance();
            getContext().setBalance(balance + amount);
            transitionState();
            Console.WriteLine("An amount " + amount + " is deposited ");
            return true;
        }
        public virtual bool withdraw(double amount)
        {
            double balance = getContext().getBalance();
            getContext().setBalance(balance - amount);
            transitionState();
            Console.WriteLine("An amount " + amount + " is withdrawn ");
            return true;
        }
    }
}
