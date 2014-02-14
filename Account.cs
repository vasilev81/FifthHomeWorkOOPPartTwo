
namespace ExerciseTwo
{
    using System;

    public abstract class Account
    {
        private int period;
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            //this.Period = period;
        }

        public int Period
        {
            get
            {
                return this.period;
            }
            set
            {
                if(value <= 0 )
                {
                    throw new ArgumentException("Period must be larger than 0 months");
                }
                this.period = value;
            }
        }
        public Customer Customer { get; set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Balance can't be negative");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate { get; set; }

        public abstract void DepositMoney(decimal sum);


        //public virtual void WithDraw(decimal sum)
        //{
        //    if ((balance - sum) < 0)
        //    {
        //        throw new ArgumentException("Can't withdraw more money than you have in the account");
        //    }
        //    balance -= sum;
        //}
    }
}
