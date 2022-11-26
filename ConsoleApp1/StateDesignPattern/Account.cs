using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StateDesignPattern
{
    public class Account
    {
        public double Balance { get; set; }
        public IAccountState AccountState { get; set; }

        public void Deposit(double amount)
        {
            AccountState.Deposit(this, amount);
        }

        public void Withdraw(double amount)
        {
            AccountState.Withdraw(this, amount);
        }

        public double GetBalance() => Balance;
    }
}
