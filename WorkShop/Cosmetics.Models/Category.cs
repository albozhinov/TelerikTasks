using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cosmetics
{
    public class Category
    {
        private readonly string name;
        private readonly List<Product> products;

        public string Name => this.name;

        public Category(string name)
        {
            if (name.Length < 2 || name.Length > 15)
            {
                throw new ArgumentOutOfRangeException("Shuuuuuu");
            }
            this.name = name;
            products = new List<Product>();

        }

        public List<Product> Products
        {
            get
            {
                return products.OrderBy(x => x.Brand).ThenByDescending(p => p.Price).ToList();
            }
        }

        public virtual void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }

            this.products.Add(product);
        }

        public virtual void RemoveProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            if (this.products.Contains(product))
            {
                products.Remove(product);
            }
            else
            {
                throw new ArgumentNullException();
            }

        }

        public string Print()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine($"#Category: {this.Name}");

            for (int i = 0; i < Products.Count; i++)
            {
                if (i == Products.Count - 1)
                {
                    strBuilder.Append(Products[i].Print());
                    continue;
                }
                strBuilder.AppendLine(Products[i].Print());

            }
            if (Products.Count == 0)
            {
                strBuilder.Append(" #No product in this category");
            }
            return strBuilder.ToString();
        }
    }
}
