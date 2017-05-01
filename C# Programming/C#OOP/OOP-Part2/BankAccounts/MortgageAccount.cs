using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override double depositMoney(int numberOfMonths)
        {
            if(this.CustomerAccount == Customer.companies)
            {
                if (numberOfMonths <= 12)
                {
                    return (this.InterestRate / 2)*numberOfMonths;
                }
                else
                {
                    return ((this.InterestRate / 2) * 12) + base.depositMoney(numberOfMonths-12);
                }
            }
            else
            {
                if (numberOfMonths <= 6)
                {
                    return 0.0;
                }
                else return base.depositMoney(numberOfMonths - 6);
            }
        }
    }
}
