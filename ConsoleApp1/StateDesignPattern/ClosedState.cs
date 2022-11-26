using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StateDesignPattern
{
    public class ClosedState : IAccountState
    {
        public void Deposit(Account account, double amount)
        {
            account.Balance += amount;
            if (account.Balance > 0)
            {
                account.AccountState = new ActiveState();
            }
        }

        public void Withdraw(Account account, double amount)
        {
            throw new InvalidOperationException();
        }
    }
}
