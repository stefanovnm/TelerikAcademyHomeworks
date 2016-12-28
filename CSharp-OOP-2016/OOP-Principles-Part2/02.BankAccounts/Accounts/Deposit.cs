namespace _02.BankAccounts.Accounts
{
    using System;
    using _02.BankAccounts.Customers;

    public class Deposit : Account, IDepositable
    {
        public Deposit(Customer customer, decimal balance, decimal monthlyRate)
            :base(customer, balance, monthlyRate)
        {
        }

        public void DepositMoney(decimal money)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException("Money for deposit should be positive!");
            }
            this.Balance += money;
        }

        public void WithdrawMoney(decimal money)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException("Money for withdraw should be positive!");
            }
            if (money > this.Balance)
            {
                throw new ArgumentOutOfRangeException("Money for withdraw should be less than the current balance!");
            }
            this.Balance -= money;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000) //balance is always positive!
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }
    }
}
