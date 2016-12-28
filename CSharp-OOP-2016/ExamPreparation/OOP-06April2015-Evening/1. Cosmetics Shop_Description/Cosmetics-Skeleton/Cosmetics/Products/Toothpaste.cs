namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Toothpaste : Product, IToothpaste
    {
        private List<string> ingredients = new List<string>();

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients) 
            : base(name, brand, price, gender)
        {
            this.Ingredients = string.Join(",", ingredients);
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", this.ingredients);
            }
            set
            {
                string allIngredients = value;
                string error = string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", 4, 12); ;

                List<string> res = new List<string>();

                foreach (var ing in allIngredients.Split(','))
                {
                    if (ing.Length < 4 || ing.Length > 12)
                    {
                        Validator.CheckIfStringLengthIsValid(ing, 12, 4, error);
                    }

                    this.ingredients.Add(ing);
                }
            }
        }

        public new string Print()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("\n- {0} - {1}:\n  * Price: ${2}\n  * For gender: {3}\n", base.Brand, base.Name, base.Price, base.Gender);

            result.AppendFormat("  * Ingredients: {0}", this.Ingredients);

            return result.ToString();
        }
    }
}
