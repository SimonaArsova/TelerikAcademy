using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class DepositAccount : Account, IDepositAccount
    {
        public DepositAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override double depositMoney(int numberOfMonths)
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0.0;
            }
            return base.depositMoney(numberOfMonths);
        }

        public double withDrawMoney(int numberOfMonths)
        {
            return numberOfMonths * this.InterestRate;
        }
    }
}
