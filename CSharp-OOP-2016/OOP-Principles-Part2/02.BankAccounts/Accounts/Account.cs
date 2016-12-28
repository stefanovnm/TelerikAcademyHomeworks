namespace _02.BankAccounts.Accounts
{
    using System;
    using _02.BankAccounts.Customers;

    public abstract class Account
    {
        const decimal EmptyAccount = 0.0m;
        const decimal DefaultMonthlyRate = 0.02m;

        private decimal balance;
        private decimal monthlyRate;

        public Account(Customer customer, decimal balance, decimal monthlyRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyRate = monthlyRate;
        }

        public Account(Customer customer)
            :this(customer, EmptyAccount, DefaultMonthlyRate)
        {
        }


        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance should not be negative!");
                }
                this.balance = value;
            }
        }

        public decimal MonthlyRate
        {
            get { return this.monthlyRate; }
            set
            {
                if (monthlyRate < 0)
                {
                    throw new ArgumentOutOfRangeException("Monthly interest rate should not be negative!");
                }
                this.monthlyRate = value;
            }
        }

        public Customer Customer { get; private set; }

        public virtual decimal CalculateInterest(int months)
        {
            if (months<0)
            {
                throw new ArgumentOutOfRangeException("Months cannot be negative!");
            }
            return this.monthlyRate / 100 * Balance * (decimal)months;
        }


    }
}
