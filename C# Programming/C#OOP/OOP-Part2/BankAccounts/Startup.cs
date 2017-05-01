using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Startup
    {
        static void Main()
        {
            DepositAccount depositAccount = new DepositAccount(Customer.companies, 900.00, 6.8);
            LoanAccount loanAccount = new LoanAccount(Customer.companies, 5000.00, 7.1);
            MortgageAccount mortrageAccount = new MortgageAccount(Customer.individuals, 20000.00, 8.0);

            //Deposit accounts have no interest if their balance is positive and less than 1000.
            Console.WriteLine("Deposit account for 6 months(Balance: 900.00): {0:F2}", depositAccount.depositMoney(6));
            //Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
            Console.WriteLine("Loan account for 3 months for a company(Interest rate:7.1): {0:F2}", loanAccount.depositMoney(3));
            //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
            Console.WriteLine("Mortrage account for 8 months for individual customer(Interest rate:8.0): {0:F2}", mortrageAccount.depositMoney(8));
        }
    }
}
