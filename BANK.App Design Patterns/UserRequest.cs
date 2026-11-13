using Bank.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK.App_Design_Patterns
{
    internal class UserRequest
    {
        static void Main(string[] args)
        {
            string AccountnumBER = "HDFC123";
            AccountControllers accountcontrollers = new AccountControllers();
            string result = accountcontrollers.GetBalance(AccountnumBER);
            Console.WriteLine(result);
        }
    }

}
