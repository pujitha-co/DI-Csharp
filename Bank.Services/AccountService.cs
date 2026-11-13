using Bank.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class AccountService

    {
        AccountREPOS accountREPOS;
        public AccountService()
        {
            accountREPOS = new AccountREPOS();
        }
        public string GetBalance(string AccountNumber)
        { 
            //AccountREPOS accountRepos = new AccountREPOS();
            string msg=accountREPOS.GetBalance(AccountNumber);
            return msg;
        }

        public string Deposit(string amount)
        {
            //AccountREPOS accountRepos = new AccountREPOS();
            accountREPOS.Deposit(amount);
            return "Deposit successful";
        }
    }
}
