namespace _02.BankAccounts.Customers
{
    using System;

    public class Individual : Customer
    {
        private string egn;

        public Individual(string name, string egn) 
            : base(name)
        {
            this.EGN = egn;
        }

        public string EGN
        {
            get { return this.egn; }
            set
            {
                if (value.Length!=10)
                {
                    throw new ArgumentException("EGN must be 10 numbers!");
                }

                this.egn = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} with EGN {2}.", this.GetType().Name, this.Name, this.egn);
        }
    }
}
