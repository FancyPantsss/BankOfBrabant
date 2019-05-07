using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfBrabant.Models
{
    public class DepositAccount:AccountAbstract
    {
        public TimeSpan timeLimit, time;
        public double CancellationFee;

        public DepositAccount(double balance, double interest, string accountNumber)
        {
            balance = this.balance;
            interest = this.interest;
            accountNumber = this.accountNumber;
        }

        public void FreezeMoney(double amount, DateTime endDate, DateTime startDate, int duration)
        {

        }
    }
}
