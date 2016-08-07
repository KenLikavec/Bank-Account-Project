using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class AccountBase
    {

        //Fields
        private string fullName = "Monopoly Guy";
        private string dateOfBirth = "02/06/1935";
        private string address = "18000 Millionaires Row, Cleveland OH 44879";
        private string phoneNumber = "888-131-9654";
        private int accountnumber = 0123456;


        //Properties
        public string FullName
        {
            get { return this.fullName; }
        }


        //Constructors

        public void printDetails()
        {
            StringBuilder accountBaseInfo = new StringBuilder();
            accountBaseInfo.Append("Name: " + fullName);
            accountBaseInfo.Append("\nDate of Birth: " + dateOfBirth);
            accountBaseInfo.Append("\nAdress " + address);
            accountBaseInfo.Append("\nPhone Number: " + phoneNumber);
            accountBaseInfo.Append("\nAccount Number: " + accountnumber);
            Console.WriteLine(accountBaseInfo.ToString());
        }

    }
}
