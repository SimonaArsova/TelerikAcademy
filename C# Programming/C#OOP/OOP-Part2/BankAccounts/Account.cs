using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Account
    {
        private Customer customer;
        private double balance;
        private double interestRate;

        public Account(Customer customer, double balance, double interestRate)
        {
            this.CustomerAccount = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer CustomerAccount
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }

        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate must be positive");
                }
                this.interestRate = value;
            }
        }

        public virtual double depositMoney(int numberOfMonths)
        {
            return numberOfMonths * this.InterestRate;
        }
    }
}
