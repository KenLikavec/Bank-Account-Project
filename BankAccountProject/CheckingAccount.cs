using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount : AccountBase
    {

        //Fields
        private int checkingAccountNumber = 01234567;
        private double checkingBalance = 380000;

        //Properties
        public int CheckingAccountNumber
        {
            get { return this.checkingAccountNumber; }
        }

        public double CheckingBalance
        {
            get { return this.checkingBalance; }
        }


        //Constructors

        public void printCheckingBalance()
        {
            Console.WriteLine("Checking Account Balance: " + "$" + checkingBalance);
        }

        public void depositeChecking()
        {
            Console.WriteLine("How much would you like to deposite? \n\n");
            int checkingDepositeAmount = int.Parse(Console.ReadLine());
            checkingBalance = checkingBalance + checkingDepositeAmount;
            Console.WriteLine();
            Console.WriteLine("Your new balance is: " + "$" + checkingBalance);
        }

        public void withdrawlChecking()
        {
            Console.WriteLine("How much would you like to withdrawl? \n\n");
            int checkingWithdrawlAmount = int.Parse(Console.ReadLine());
            checkingBalance = checkingBalance - checkingWithdrawlAmount;
            Console.WriteLine();
            Console.WriteLine("Your new balance is: " + "$" + checkingBalance);
        }
    }
}
