using Cosmetics.Products;
using System;
using System.Collections.Generic;
using Cosmetics;
using System.Linq;

namespace Cosmetics.Cart
{
    public class ShoppingCart
    {
        private readonly ICollection<Product> productList;

        public ShoppingCart()
        {
            this.productList = new List<Product>();
        }

        public ICollection<Product> ProductList
        {
            get { return this.productList; }
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            this.productList.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            if (this.ProductList.Contains(product))
            {
                ProductList.Remove(product);
            }
        }

        public bool ContainsProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            if (this.ProductList.Contains(product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal TotalPrice()
        {
            return ProductList.Sum(p => p.Price);
        }
    }
}
