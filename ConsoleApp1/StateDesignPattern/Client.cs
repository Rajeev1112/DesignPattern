using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StateDesignPattern
{
    public class Client
    {
        public void Execute()
        {
            Account account = new Account();
            account.Balance = 100;
            account.AccountState = new ActiveState();

            account.Deposit(100);

            Console.WriteLine($"Balance={account.GetBalance()}");
            Console.WriteLine($"State={account.AccountState.GetType()}");

            account.Withdraw(300);

            Console.WriteLine($"Balance={account.GetBalance()}");
            Console.WriteLine($"State={account.AccountState.GetType()}");
        }
    }
}
