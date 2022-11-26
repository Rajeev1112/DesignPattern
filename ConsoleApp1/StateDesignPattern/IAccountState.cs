using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StateDesignPattern
{
    public interface IAccountState
    {
        void Withdraw(Account account, double amount);
        void Deposit(Account account, double amount);
    }
}
