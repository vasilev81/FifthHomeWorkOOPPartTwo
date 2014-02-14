
namespace ExerciseTwo
{
    using System;
    class Deposit : Account, IWithdrawSum, IInterestAmount
    {
        private const decimal minimalSumForInterest = 1000;
        public Deposit(Customer customer, decimal balance, decimal interestRate) : base(customer,balance,interestRate)
        {
         
        }
        public override void DepositMoney(decimal sum)
        {
            if (sum < 0)
            {
                throw new ArgumentException("You can't deposit negative sum");
            }
            Balance += sum;
        }

        public void WithDraw(decimal sum)
        {
            if ((Balance - sum) < 0)
            {
                throw new ArgumentException("Can't withdraw more money than you have in the account");
            }
            Balance -= sum;
        }

        public decimal InterestAmount()
        {
            if(Balance < minimalSumForInterest )
            {
                return 0;
            }
            else
            {
                return this.Period * this.InterestRate;
            }
        }
    }
}
