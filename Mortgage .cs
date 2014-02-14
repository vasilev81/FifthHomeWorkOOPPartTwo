
namespace ExerciseTwo
{
    using System;
    public class Mortgage : Account, IInterestAmount
    {
        private const int individualDiscount = 6;
        private const int companydiscount = 12;
        private const int halfInterestamount = 2;
         public Mortgage(Customer customer, decimal balance, decimal interestRate) : base(customer,balance,interestRate)
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

        public decimal InterestAmount()
        {
            if(Customer is Individual)
            {
                return (this.Period - individualDiscount) * this.InterestRate;
            }
            else
            {
                return ((companydiscount * this.InterestRate) / halfInterestamount) + ((this.Period - companydiscount) * this.InterestRate);
            }
        }
    }
}
