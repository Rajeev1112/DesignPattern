using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StateDesignPattern
{
    public class ActiveState : IAccountState
    {
        public void Deposit(Account account, double amount)
        {
            account.Balance += amount;
            
        }

        public void Withdraw(Account account, double amount)
        {
            account.Balance -= amount;

            if (account.Balance <= 0 && account.Balance >= -100)
                account.AccountState = new OverdraftState();
            else if (account.Balance <= -100)
                account.AccountState = new ClosedState();
        }
    }
}
