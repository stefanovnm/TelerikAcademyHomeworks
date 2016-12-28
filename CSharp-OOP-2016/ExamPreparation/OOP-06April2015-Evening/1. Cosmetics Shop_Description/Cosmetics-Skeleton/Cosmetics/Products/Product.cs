namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Engine;

    public abstract class Product : IProduct
    {
        private string brand;
        private string name;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }



        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                string error = string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", 2, 10);
                Validator.CheckIfStringLengthIsValid(value, 10, 2, error);
                this.brand = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                string error = string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", 3, 10);
                Validator.CheckIfStringLengthIsValid(value, 10, 3, error);
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
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

        public string Print()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("- {0} - {1}\n  * Price: ${2}\n  * For gender: {3}\n", this.Brand, this.Name, this.Price, this.Gender);

            return result.ToString();
        }
    }
}
