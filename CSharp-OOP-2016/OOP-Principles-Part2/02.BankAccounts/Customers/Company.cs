namespace _02.BankAccounts.Customers
{
    using System;

    public class Company : Customer
    {
        private string eik;

        public Company(string name, string eik) 
            : base(name)
        {
            this.EIK = eik;
        }

        public string EIK
        {
            get { return this.eik; }
            set
            {
                if (value.Length < 13 || value.Length > 15)
                {
                    throw new ArgumentException("EIK should be between 13 and 15 symbols!");
                }
                this.eik = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} with EIK {2}", this.GetType().Name, this.Name, this.EIK);
        }
    }
}
