using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : AccountBase
    {

        //Fields
        private int savingsAccountNumber = 0123456789;
        private double savingsBalance = 180000;

        //Properties
        public int SavingsAccountNumber
        {
            get { return this.savingsAccountNumber; }
        }
        public double SavingAccountBalance
        {
            get { return this.savingsBalance; }
        }

        //Constructors

        public void printSavingsBalance()
        {
            Console.WriteLine("Savings Account Balance: " + "$" + savingsBalance);
        }

        public void depositeSavings()
        {
            Console.WriteLine("How much would you like to deposite? \n\n");
            int savingsDepositeAmount = int.Parse(Console.ReadLine());
            savingsBalance = savingsBalance + savingsDepositeAmount;
            Console.WriteLine();
            Console.WriteLine("Your new balance is: " + "$" + savingsBalance);
        }

        public void withdrawlSavings()
        {
            Console.WriteLine("How much would you like to withdrawl? \n\n");
            int savingsWithdrawlAmount = int.Parse(Console.ReadLine());
            savingsBalance = savingsBalance - savingsWithdrawlAmount;
            Console.WriteLine();
            Console.WriteLine("Your new balance is: " + "$" + savingsBalance);
        }

    }
}
