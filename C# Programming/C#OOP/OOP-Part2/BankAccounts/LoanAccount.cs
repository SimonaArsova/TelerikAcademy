using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override double depositMoney(int numberOfMonths)
        {
            if(this.CustomerAccount == Customer.individuals)
            {
                return (numberOfMonths - 3) * this.InterestRate;
            }
            return (numberOfMonths - 2) * this.InterestRate;
        }
    }
}
