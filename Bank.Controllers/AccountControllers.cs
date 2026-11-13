using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Controllers
{
    public class AccountControllers
    {

        AccountService accountService;
        public AccountControllers()
        {
            accountService = new AccountService();
        }

        public string GetBalance(string accountnum)
        {


          //  AccountService accountService = new AccountService();
            string msg = accountService.GetBalance(accountnum);
            return msg;
        }
    }
}
