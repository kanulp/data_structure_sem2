using System;
namespace StatePattern
{
    public class TransactionFeeState : State
    {
        public TransactionFeeState(Account account) : base(account)
        {
        }

        public TransactionFeeState(State source) : base(source)
        {
        }

        public override bool deposit(double amount)
        {
            return base.deposit(amount);
        }
        public override bool withdraw(double amount)
        {
            double balance = getContext().getBalance();

            if ((balance - amount) >
                Account.OVERDRAW_LIMIT)
            {
                base.withdraw(amount);
                return true;
            }
            else
            {
                Console.WriteLine(Account.ERR_OVERDRAW_LIMIT_EXCEED);
                return false;
            }
        }

        public override State transitionState()
        {
            double balance = getContext().getBalance();
            if (balance < 0)
            {
                getContext().setState(new OverDrawnState(this));
            }
            else
            {
                if (balance < Account.MIN_BALANCE)
                {
                    getContext().setState(new TransactionFeeState(this));
                }
            }
            return getContext().getState();
        }
    }
}
