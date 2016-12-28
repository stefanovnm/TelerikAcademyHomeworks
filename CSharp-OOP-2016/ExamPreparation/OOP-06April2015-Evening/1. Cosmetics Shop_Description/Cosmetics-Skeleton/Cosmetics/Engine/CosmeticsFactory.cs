namespace Cosmetics.Engine
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;

    public class CosmeticsFactory : ICosmeticsFactory
    {


        public ICategory CreateCategory(string name)
        {
            //TODO: check if exist!
            Category category = new Category(name);

            return category;
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            //TODO:
            Shampoo shampoo = new Shampoo(name, brand, price, gender, milliliters, usage);

            return shampoo;
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            //TODO:
            Toothpaste toothpaste = new Toothpaste(name, brand, price, gender, ingredients);
            return toothpaste;
        }

        public IShoppingCart ShoppingCart()
        {
            ShoppingCart cart = new ShoppingCart();
            return cart;
        }
    }
}
