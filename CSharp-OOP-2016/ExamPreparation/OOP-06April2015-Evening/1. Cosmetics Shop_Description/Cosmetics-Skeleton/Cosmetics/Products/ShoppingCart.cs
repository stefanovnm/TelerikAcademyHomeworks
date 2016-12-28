using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{

    using Cosmetics.Contracts;
    public class ShoppingCart : IShoppingCart
    {
        private List<IProduct> allProducts = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            allProducts.Add(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (allProducts.Contains(product))
            {
                return true;
            }
            return false;
        }

        public void RemoveProduct(IProduct product)
        {
            allProducts.Remove(product);
        }

        public decimal TotalPrice()
        {
            decimal price = 0M;

            foreach (var product in allProducts)
            {
                price += product.Price;
            }

            return price;
        }
    }
}
