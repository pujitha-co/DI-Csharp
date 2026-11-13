using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repos
{
    public class AccountREPOS
    {
        string Accountnumber = "HDFC123";
        public string GetBalance(string Accountnumber)
        {
            if (Accountnumber == "HDFC123")
            {
                return "you are having 10000 balance";
            }
            else

            {
                return "Account number is not valid";
            }
        }
            public string Deposit(string amount)
        {
            return $"user deposit the {amount}.success... ";
        }

         

        
    }
}


