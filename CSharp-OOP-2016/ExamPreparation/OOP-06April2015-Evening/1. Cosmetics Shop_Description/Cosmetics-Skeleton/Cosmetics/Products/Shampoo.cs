namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;
        private decimal price;


        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            :base(name, brand, price, gender)
        {
            this.price = price;
            this.milliliters = milliliters;
            this.usage = usage;
        }

        public new decimal Price
        {
            get
            {
                return this.price * (decimal)milliliters;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("negative price!");
                }

                this.price = value;
            }
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("negative milliliters");
                }

                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }
            set
            {
                 this.usage = value;
            }
        }

        public new string Print()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("\n- {0} - {1}:\n  * Price: ${2}\n  * For gender: {3}\n", base.Brand, base.Name, this.Price, base.Gender);

            result.AppendFormat("  * Quantity: {0} ml\n  * Usage: {1}", this.milliliters, this.usage);

            return result.ToString();
        }
    }
}
