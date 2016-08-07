using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Objects
            AccountBase Monopoly = new AccountBase();
            CheckingAccount MonopolyC = new CheckingAccount();
            ReserveAccount MonopolyR = new ReserveAccount();
            SavingsAccount MonopolyS = new SavingsAccount();

            //Variables used for the answer when the user is prompted to return to menu
            string mainReturn;
            string balanceReturn;
            string depositeReturn;
            string withdrawlReturn;
            //Variables used for switch case options, when the user is prompted to input their decision
            int balanceOptions;
            int depositeOptions;
            int withdrawlOptions;

            do
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU \n\n1. View Client Information \n2. View Account Balances \n3. Deposite Funds \n4. Withdrawl Funds \n5. Exit \n\n");
                int menuAnswer = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (menuAnswer)
                {
                    case 1:
                        Monopoly.printDetails();
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Balancy Inquiry Menu: \n1. Checking Account Balance \n2. Reserve Account Balance \n3. Savings Account Balance \n\n");
                            balanceOptions = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (balanceOptions)
                            {
                                case 1:
                                    {
                                        MonopolyC.printCheckingBalance();
                                        break;
                                    }
                                case 2:
                                    {
                                        MonopolyR.printReserveBalance();
                                        break;
                                    }
                                case 3:
                                    {
                                        MonopolyS.printSavingsBalance();
                                        break;
                                    }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Press \"Enter\" to continue_");
                            Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine("Would you like to return to the Balance Inquiry Menu? (YES/NO) \n\n");
                            balanceReturn = Console.ReadLine().ToUpper();
                            Console.Clear();
                        } while (balanceReturn == "YES");
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Deposite Funds: \nWhich account would you like to deposite your funds? \n\n1. Checking Account \n2. Reserve Account \n3. Savings Account \n\n");
                            depositeOptions = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (depositeOptions)
                            {
                                case 1:
                                    {
                                        MonopolyC.depositeChecking();
                                        break;
                                    }
                                case 2:
                                    {
                                        MonopolyR.depositeReserve();
                                        break;
                                    }
                                case 3:
                                    {
                                        MonopolyS.depositeSavings();
                                        break;
                                    }
                            }

                            Console.WriteLine("Would you like to retrun to the Deposite Funds Menu? (YES/NO) \n\n");
                            depositeReturn = Console.ReadLine().ToUpper();
                            Console.Clear();
                        } while (depositeReturn == "YES");
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("Withdrawl Funds: \nWhich account would you like to withdrawl your funds? \n\n1. Checking Account \n2. Reserve Account \n3. Savings Account \n\n");
                            withdrawlOptions = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (withdrawlOptions)
                            {
                                case 1:
                                    {
                                        MonopolyC.withdrawlChecking();
                                        break;
                                    }
                                case 2:
                                    {
                                        MonopolyR.withdrawlReserve();
                                        break;
                                    }
                                case 3:
                                    {
                                        MonopolyS.withdrawlSavings();
                                        break;
                                    }
                            }
                            Console.WriteLine("Would you like to return to the Withdrawl Funds Menu? (YES/NO) \n\n");
                            withdrawlReturn = Console.ReadLine().ToUpper();
                            Console.Clear();
                        } while (withdrawlReturn == "YES"); 
                        break;    
                }

                
                Console.WriteLine("Would you like to return to the main menu? (YES/NO) \n\n");
                mainReturn = Console.ReadLine().ToUpper();
                Console.Clear();
            }
            while (mainReturn == "YES");
            












            Console.ReadKey();
        }
    }
}
