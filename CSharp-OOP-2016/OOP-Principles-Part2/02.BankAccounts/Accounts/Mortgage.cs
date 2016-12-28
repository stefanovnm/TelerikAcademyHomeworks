namespace _02.BankAccounts.Accounts
{
    using System;
    using _02.BankAccounts.Customers;

    public class Mortgage : Account, IDepositable
    {
        public Mortgage(Customer customer, decimal balance, decimal montlyRate)
            : base(customer, balance, montlyRate)
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
                throw new ArgumentOutOfRangeException("You cannot deposit more money than the mortage!");
            }
            this.Balance -= money;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterest(months - 6);
                }
            }

            if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    return months * MonthlyRate / 100 * Balance / 2;
                }
                else
                {
                    return 12 * MonthlyRate / 100 / 2 * Balance + base.CalculateInterest(months - 12);
                }
            }

            return base.CalculateInterest(months);//not reachable
        }
    }
}
