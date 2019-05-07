using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfBrabant.Models
{
    public class SpendingAccount:AccountAbstract
    {
        public SpendingAccount(double balance, double interest, string accountNumber)
        {
            balance = this.balance;
            interest = this.interest;
            accountNumber = this.accountNumber;
        }

        public new void AddMoney(double addToSaving)
        {
            balance += addToSaving;
        }

        public new void WithdrawMoney(double outGoing)
        {
            balance -= outGoing;
        }
    }
}
