using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class ReserveAccount : AccountBase
    {

        //Fields
        private int reserveAccountNumber = 012345678;
        private double reserveBalance = 280000;

        //Properties
        public int ReserveAccountNumber
        {
            get { return this.reserveAccountNumber; }
        }
        public double ReserveBalance
        {
            get { return this.reserveBalance; }
        }

        //Constructors

        public void printReserveBalance()
        {
            Console.WriteLine("Reserve Account Balance: " + "$" + reserveBalance);
        }

        public void depositeReserve()
        {
            Console.WriteLine("How much would you like to deposite? \n\n");
            int reserveDepositeAmount = int.Parse(Console.ReadLine());
            reserveBalance = reserveBalance + reserveDepositeAmount;
            Console.WriteLine();
            Console.WriteLine("Your new balance is: " + "$" + reserveBalance);
        }
        
        public void withdrawlReserve()
        {
            Console.WriteLine("How much would you like to withdrawl? \n\n");
            int reserveWithdrawlAmount = int.Parse(Console.ReadLine());
            reserveBalance = reserveBalance - reserveWithdrawlAmount;
            Console.WriteLine();
            Console.WriteLine("Your new balance is " + "$" + reserveBalance);
        }

    }
}
