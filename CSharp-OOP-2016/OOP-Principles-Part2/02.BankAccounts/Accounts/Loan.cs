namespace _02.BankAccounts.Accounts
{
    using System;
    using _02.BankAccounts.Customers;

    public class Loan : Account, IDepositable
    {
        public Loan(Customer customer, decimal balance, decimal monthlyRate)
            :base(customer, balance, monthlyRate)
        {
        }

        public void DepositMoney(decimal money)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException("Money for deposit should be positive!");
            }
            if (money > this.Balance)
            {
                throw new ArgumentOutOfRangeException("You cannot deposit more money than the loan!");
            }
            this.Balance -= money;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    months -= 3;
                }
            }

            if (this.Customer is Company)
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    months -= 2;
                }
            }

            return base.CalculateInterest(months);
        }
    }
}
