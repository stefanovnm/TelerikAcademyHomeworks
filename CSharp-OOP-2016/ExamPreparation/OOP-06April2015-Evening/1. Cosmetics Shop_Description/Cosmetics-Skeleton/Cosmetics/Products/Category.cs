namespace Cosmetics.Products
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Engine;

    public class Category : ICategory
    {
        private string name;
        private List<IProduct> category = new List<IProduct>();

        public Category(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                string error = string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2, 15);
                Validator.CheckIfStringLengthIsValid(value, 15, 2, error);
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.category.Add(cosmetics);
            //this.category = this.category.OrderBy(x => x.Brand).ThenByDescending(y => y.Price).ToList();
        }

        public string Print()
        {
            this.category = this.category.OrderBy(x => x.Brand).ThenByDescending(y => y.Price).ToList();

            StringBuilder result = new StringBuilder();

            if (this.category.Count == 1)
            {
                result.AppendFormat("{0} category - {1} product in total", this.Name, this.category.Count);
            }
            else
            {
                result.AppendFormat("{0} category - {1} products in total", this.Name, this.category.Count);
            }
            
            foreach (var product in category)
            {
                result.Append(product.Print());
            }

            return result.ToString();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (category.IndexOf(cosmetics)==-1)
            {
                string error = string.Format("Product {0} does not exist in category {1}!",cosmetics.Name,this.name);
                throw new ArgumentException();
            }

            this.category.Remove(cosmetics);
        }

        public void SortCategory(List<IProduct> list)
        {
            list.OrderBy(x => x.Brand).ThenByDescending(y => y.Price).ToList();
        }
    }
}
