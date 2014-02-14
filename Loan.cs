
namespace ExerciseTwo
{
    using System;
    public class Loan : Account,IInterestAmount
    {      
        private const int individualDiscount = 3;
        private const int companyDiscount = 2;
        public Loan(Customer customer, decimal balance, decimal interestRate) : base(customer,balance,interestRate)
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
           if( Customer is Individual )
           {
               return (this.Period - individualDiscount) * this.InterestRate;
           }
           else
           {
               return (this.Period - companyDiscount) * this.InterestRate;
           }
        }
    }
}
