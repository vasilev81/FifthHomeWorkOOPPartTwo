
namespace ExerciseTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Test
    {
        static void Main()
        {
            var customer = new Individual();
            var deposit = new Deposit(customer, 100, 8);
            deposit.DepositMoney(100);
            deposit.WithDraw(25); 
            deposit.Period = 12;

            var newDeposit = new Deposit(new Company(), 2000, 4);
            newDeposit.Period = 36;
            Console.WriteLine(deposit.InterestAmount());

            Console.WriteLine(newDeposit.InterestAmount());
            Console.WriteLine();

            var loan = new Loan(customer, 15000, 8);
            loan.Period = 12;
            Console.WriteLine(loan.InterestAmount());

            Console.WriteLine();

            var newLoan = new Loan(new Company(), 15000, 8);
            newLoan.Period = 12;
            Console.WriteLine(newLoan.InterestAmount());
            //Console.WriteLine(deposit.Balance);
        }
    }
}
