using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste
    {        
        private IList<string> ingredients;          

        public IList<string> Ingredients
        {
            get { return new List<string>(this.ingredients); }
        }

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            if (ingredients == null)
            {
                throw new ArgumentNullException();
            }
            this.ingredients = ingredients;
        }

        public override string Print()
        {
            return $"#{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}\r\n #Ingredients: {string.Join(", ", this.Ingredients)}";
        }
    }
}