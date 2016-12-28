namespace _02.BankAccounts
{
    using System;
    using _02.BankAccounts.Accounts;
    using _02.BankAccounts.Customers;

    public class Tests
    {
        public static void Main()
        {
            Company[] companies =
            {
                new Company("Company 1", "1234567890001"),
                new Company("Company 2", "1234567890002"),
                new Company("Company 3", "1234567890003")
            };

            Individual[] customers =
            {
                new Individual("Ivan Ivanov","8001012222"),
                new Individual("Maq Pencheva", "8109091111"),
                new Individual("Pesho Peshov", "8609093333")
            };

            Account[] allAcounts =
            {
                new Loan (customers[0],5000,1.2m),
                new Mortgage(customers[0], 30000, 0.6m),
                new Deposit (customers[1],800,0.7m),
                new Loan(customers[2],500,1.06m),
                new Deposit(companies[0],5000.5m,0.76m),
                new Loan(companies[1], 5000, 0.94m),
                new Mortgage(companies[2],10000, 0.65m)
            };

            int testMonths = 15;

            foreach (var account in allAcounts)
            {
                Console.WriteLine("{0}\n{1} (value:{3:C}, month interest {4}%), interest for {5} months {2:C}\n", account.Customer, account.GetType().Name, account.CalculateInterest(testMonths), account.Balance, account.MonthlyRate, testMonths);
            }
            //test DepositMoney and WithdrawMoney
            Deposit forWithdraw = new Deposit(customers[0], 500.5m, 0.56m);
            Console.WriteLine("Money in deposit account: {0:C}\nWithdraw 500 from them:", forWithdraw.Balance);
            forWithdraw.WithdrawMoney(500);
            Console.WriteLine("Money after withdraw: {0:C}", forWithdraw.Balance);
            forWithdraw.DepositMoney(1000);
            Console.WriteLine("Money after deposit of 1000: {0:C}", forWithdraw.Balance);

            Console.WriteLine();
            Loan testLoan = new Loan(customers[1], 6000, 0.56m);
            Console.WriteLine("Debt in Loan account: {0:C}", testLoan.Balance);
            testLoan.DepositMoney(5000);
            Console.WriteLine("Debt in loan account after deposit 5000: {0:C}", testLoan.Balance);

            Console.WriteLine();
            Mortgage testMortgage = new Mortgage(companies[0], 100000, 0.35m);
            Console.WriteLine("Mortage value {0:C}", testMortgage.Balance);
            testMortgage.DepositMoney(3500.50m);
            Console.WriteLine("Mortage value after depositing 3500.50: {0:C}", testMortgage.Balance);
            Console.WriteLine("Interest for it for 2 months: {0:C}", testMortgage.CalculateInterest(2));
        }
    }
}
